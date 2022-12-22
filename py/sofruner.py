import _thread
import configparser
import os
import subprocess
import threading
import tkinter
import tkinter.messagebox
from tkinter.filedialog import askdirectory

import pystray
from PIL import Image


def gui_main():
    root = tkinter.Tk()
    root.title( "sofruner gui v1.4" )             # set window title
    root.geometry( '390x80' )                     # set window size
    root.iconbitmap( "../icon/sofrunerico.ico" )  # set window ico
    root.resizable( width = False , height = False )
    # this window isn't resizable

    # setup root widget

    def quit_window( icon: pystray.Icon ):
        icon.stop()
        root.destroy()

    def show_window():
        root.deiconify()
    
    def window_on_exit():
        root.withdraw()

    # functions for pystray

    tray_menu = ( pystray.MenuItem( "显示面板" , show_window , default = True ) , pystray.Menu.SEPARATOR , pystray.MenuItem( "退出" , quit_window ) )
    tray_icon = Image.open( "../icon/sofrunerico.ico" )
    tray = pystray.Icon( "sofruner" , tray_icon , "sofruner" , tray_menu )
    # define system tray

    root.protocol( "WM_DELETE_WINDOW" , window_on_exit )
    # redefine "close window" button

    Target_Path = tkinter.StringVar()
    Target_EXE = tkinter.StringVar()
    Checkbutton_Var = tkinter.IntVar()

    rConfig = configparser.ConfigParser()
    rConfig.read( "../config/config.ini" , encoding = "utf-8" )

    Checkbutton_Var.set( rConfig["sofruner"]["save_profil"] )
    if Checkbutton_Var.get() == 1: # set profil setting from config
        Target_Path.set( rConfig["sofruner"]["target_path"] )
        Target_EXE.set( rConfig["sofruner"]["target_exe"] )
    else:
        Target_EXE.set( "launcher.exe" )

    def select_path():
        pathtemp = askdirectory()
        Target_Path.set( pathtemp )

    def run_target():
        if Checkbutton_Var.get() == 1:
            try:
                rConfig.set( "sofruner" , "target_path" , Target_Path.get() )
                rConfig.set( "sofruner" , "target_exe" , Target_EXE.get() )
            except configparser.DuplicateOptionError:
                tkinter.messagebox.showerror( "sofruner FATAL" , "config write failed due to unknown error" )
            
            rConfig.write( open( "../config/config.ini" , "w" , encoding = "utf-8" ) )

        exe_to_run = Target_Path.get() + "/" + Target_EXE.get()
        # create exe path

        if not os.path.exists( exe_to_run ):
            tkinter.messagebox.showerror( "sofruner FATAL" , "可执行文件 " + exe_to_run + " 未找到" )
            return

#       def run( target ):
#           os.system( target )

        # normally, os.system don't need path input because it had already been contained in target
        # but not idea what happens but when I delete path, this program won't start a thread successfully
        # therefore: path isn't deleted, but it's also not used

        # but now this problem has been solved: f**k it tuple I didn't realized it

        def run( target ):
            subprocess.run( target , shell = True )

        try:
            _thread.start_new_thread( run , ( "\"" + exe_to_run + "\"" , ) )
            # start a new thread to contain and run target exe
        except:
            tkinter.messagebox.showerror( "sofruner FATAL" , "start thread failed" )
        

    def change_saveprofil_option():
        if Checkbutton_Var.get() == 1:
            set_value = "1"
        if Checkbutton_Var.get() == 0:
            set_value = "0"

        try:
            rConfig.set( "sofruner" , "save_profil" , set_value )
        except configparser.DuplicateOptionError:
            tkinter.messagebox.showerror( "sofruner FATAL" , "config write failed due to unknown error" )

        rConfig.write( open( "../config/config.ini" , "w" , encoding = "utf-8" ) )

    Target_Path_Label = tkinter.Label( root , text = "游戏目录" )
    Target_EXE_Label = tkinter.Label( root , text = "游戏程序" )
    # create label

    Target_Path_Label.grid( sticky = 'e' )
    Target_EXE_Label.grid( sticky = 'e' )
    # setup label grid

    Target_Path_Entry = tkinter.Entry( root , textvariable = Target_Path , width = 30 )
    Target_Path_Entry.configure( state = "readonly" )
    Target_EXE_Entry = tkinter.Entry( root  , textvariable = Target_EXE , width = 30 )
    # create entry

    Target_Path_Entry.grid( row = 0 , column = 1 )
    Target_EXE_Entry.grid( row = 1 , column = 1 )
    # setup entry grid

    Save_Setup_Checkbutton = tkinter.Checkbutton( root , text = "保存此设置并再下次启动时恢复" , variable = Checkbutton_Var , command = change_saveprofil_option )
#   Save_Setup_Checkbutton.select()
    # create save-setup checkbutton

    Save_Setup_Checkbutton.grid( columnspan = 2 , sticky = 'w' )
    # setup checkbutton grid

    icon = tkinter.PhotoImage( file = "../icon/icon.gif" )
    Icon_Label = tkinter.Label( image = icon )
    Icon_Label.grid( row = 0 , column = 2 , columnspan = 2 , rowspan = 2 , sticky = 'w' + 'e' + 'n' + 's' , padx = 5 , pady = 5 )

    Target_Path_Button = tkinter.Button( root , text = "选择目录" , bg = "lightblue" , command = select_path )
    Target_Run_Button = tkinter.Button( root , text = "启动游戏" , bg = "lightblue" , command = run_target )
    # create button
    
    Target_Path_Button.grid( row = 2 , column = 2 )
    Target_Run_Button.grid( row = 2 , column = 3 )
    # setup button grid

    threading.Thread( target = tray.run , daemon = True ).start()
    root.mainloop()

if __name__ == "__main__":
    gui_main()
