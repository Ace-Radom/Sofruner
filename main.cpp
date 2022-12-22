#include<Python.h>
#include<windows.h>
#include"find_process.h"

#define PyModule_AppendPath( path )                             \
{                                                               \
    PyRun_SimpleString( "import sys" );                         \
    PyRun_SimpleString( "sys.path.append( '" path "')" );       \
}

#if PY_MAJOR_VERSION < 3

    #define PyImport_Module( module ) PyObject* Py_##module = PyImport_Import( PyString_FromString( #module ) )

#else

    #define PyImport_Module( module ) PyObject* Py_##module = PyImport_Import( PyUnicode_FromString( #module ) )

#endif

#define PyImport_Function( module , function ) PyObject* PyFunc_##function = PyObject_GetAttrString( module , #function )
#define PyFunction_Callable( function )                         \
        ( function && PyCallable_Check( function ) ) ? true     \
                                                     : false

void HideShell(){
    HWND hwnd = GetForegroundWindow();
    if ( hwnd )
    {
        ShowWindow( hwnd , SW_HIDE );
    }
    return;
}

int main( int argc , char** argv ){

    Py_Initialize();
    if ( !Py_IsInitialized() )
    {
        PyErr_Print();
        system( "pause" );
        return -1;
    }

    int pcount = find_process( "sofruner.exe" );
    if ( pcount == FP_HANDLECREATEFAILED )
    {
        printf( "create process snapshot handle failed\n" );
        return -1;
    }
    if ( pcount > 1 ) // sofruner is running (the one process is this process itself)
    {
        HideShell();
        PyRun_SimpleString( "from tkinter import messagebox\n"
                            "messagebox.showinfo( \"sofruner INFO\" , \"sofruner已在运行\" )" );
        Py_Finalize();
        return 1;
    }
    
    PyModule_AppendPath( "../py" );
    PyImport_Module( sofruner );
    if ( !Py_sofruner )
    {
        PyErr_Print();
        system( "pause" );
        return -1;
    }

    PyImport_Function( Py_sofruner , gui_main );
    if ( !PyFunction_Callable( PyFunc_gui_main ) )
    {
        PyErr_Print();
        system( "pause" );
        return -1;
    }

    HideShell();
    // hide shell

    PyObject_CallObject( PyFunc_gui_main , NULL );

    Py_Finalize();

    return 0;

}