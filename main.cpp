#include<Python.h>
#include<windows.h>

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

    printf( "[sofruner shell runtime] start initializing python api\n" );
    Py_Initialize();
    if ( !Py_IsInitialized() )
    {
        PyErr_Print();
        system( "pause" );
        return -1;
    }
    printf( "[sofruner shell runtime] initializing python api success\n" );

    PyModule_AppendPath( "../py" );
    printf( "[sofruner shell runtime] trying to import python module sofruner -> cxx\n" );
    PyImport_Module( sofruner );
    if ( !Py_sofruner )
    {
        PyErr_Print();
        system( "pause" );
        return -1;
    }
    printf( "[sofruner shell runtime] import python module sofruner success\n" );

    printf( "[sofruner shell runtime] trying to import python function gui_main from python module sofruner -> cxx\n" );
    PyImport_Function( Py_sofruner , gui_main );
    if ( !PyFunction_Callable( PyFunc_gui_main ) )
    {
        PyErr_Print();
        system( "pause" );
        return -1;
    }
    printf( "[sofruner shell runtime] import python function gui_main from python module sofruner success\n" );

    printf( "[sofruner shell runtime] all perparations clear, no error occurs\n" );
    printf( "[sofruner shell runtime] calling sofruner gui...\n" );

    HideShell();
    // hide shell

    PyObject_CallObject( PyFunc_gui_main , NULL );

    Py_Finalize();

    return 0;

}