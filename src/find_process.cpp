#include"find_process.h"

int find_process( std::string process_name ){
    int pcount = 0;
    // process count

    PROCESSENTRY32 pe32;

    pe32.dwSize = sizeof( PROCESSENTRY32 );
    HANDLE process_snapshot_handle = CreateToolhelp32Snapshot( TH32CS_SNAPPROCESS , 0 );
    // create process snapshot handle

    if ( process_snapshot_handle == INVALID_HANDLE_VALUE )
    {
        return FP_HANDLECREATEFAILED;
    }

    bool is_exist = Process32First( process_snapshot_handle , &pe32 );
    // find the first process

    while ( is_exist )
    {
        if ( !stricmp( process_name.c_str() , pe32.szExeFile ) ) // process name isn't case sensitive
        {
            pcount++; // find one process running
        }
        is_exist = Process32Next( process_snapshot_handle , &pe32 );
    }

    return pcount;
}