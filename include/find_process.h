#ifndef _FIND_PROCESS_H_
#define _FIND_PROCESS_H_

#include<Windows.h>
#include<TlHelp32.h>
#include<string>

#define FP_HANDLECREATEFAILED -1
#define FP_NOTRUNNING          0

int find_process( std::string process_name );

#endif

