import tkinter
from tkinter.filedialog import askdirectory


def gui_main():
    root = tkinter.Tk()
    root.title( "sofruner gui v1.0" ) # set window title
    root.geometry( '390x80' )         # set window size
    root.resizable( width = False , height = False )
    # this window isn't resizable

    # setup root widget

    Target_Path = tkinter.StringVar()
    Checkbutton_Var = tkinter.IntVar()

    def select_path():
        pathtemp = askdirectory()
        Target_Path.set( pathtemp )

    def run_target():
        if Checkbutton_Var.get() == 1:
            print( "Yes" )
    
    Target_Path_Label = tkinter.Label( root , text = "游戏目录" )
    Target_EXE_Label = tkinter.Label( root , text = "游戏程序" )
    # create label

    Target_Path_Label.grid( sticky = 'e' )
    Target_EXE_Label.grid( sticky = 'e' )
    # setup label grid

    Target_Path_Entry = tkinter.Entry( root , textvariable = Target_Path , width = 30 )
    Target_Path_Entry.configure( state = "readonly" )
    Target_EXE_Entry = tkinter.Entry( root  , width = 30 )
    Target_EXE_Entry.delete( 0 , "end" )
    Target_EXE_Entry.insert( 0 , "launcher.exe" )
    # create entry

    Target_Path_Entry.grid( row = 0 , column = 1 )
    Target_EXE_Entry.grid( row = 1 , column = 1 )
    # setup entry grid

    Save_Setup_Checkbutton = tkinter.Checkbutton( root , text = "保存此设置并再下次启动时恢复" , variable = Checkbutton_Var )
    Save_Setup_Checkbutton.select()
    # create save-setup checkbutton

    Save_Setup_Checkbutton.grid( columnspan = 2 , sticky = 'w' )
    # setup checkbutton grid

    icon = tkinter.PhotoImage( file = "../config/icon.gif" )
    Icon_Label = tkinter.Label( image = icon )
    Icon_Label.grid( row = 0 , column = 2 , columnspan = 2 , rowspan = 2 , sticky = 'w' + 'e' + 'n' + 's' , padx = 5 , pady = 5 )

    Target_Path_Button = tkinter.Button( root , text = "打开路径" , bg = "lightblue" , command = select_path )
    Target_Run_Button = tkinter.Button( root , text = "启动游戏" , bg = "lightblue" , command = run_target )
    # create button
    
    Target_Path_Button.grid( row = 2 , column = 2 )
    Target_Run_Button.grid( row = 2 , column = 3 )
    # setup button grid

    root.mainloop()

if __name__ == "__main__":
    gui_main()
