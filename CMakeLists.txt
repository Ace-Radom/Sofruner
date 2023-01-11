cmake_minimum_required(VERSION 3.10)
project(sofruner VERSION 1.4.2)

set(CMAKE_CXX_STANDARD_REQUIRED ON)
set(CMAKE_CXX_STANDARD 14)
#set(CMAKE_CXX_FLAGS ${CMAKE_CXX_FLAGS} "-mwindows -static-libgcc -static-libstdc++")
set(CMAKE_CXX_FLAGS ${CMAKE_CXX_FLAGS} "-mwindows")

set(CMAKE_INSTALL_PREFIX ${CMAKE_SOURCE_DIR}/release_package)

set(BUILD_RELEASE ON)

set(MAKE_COMMAND "mingw32-make")

if(${BUILD_RELEASE})

    set(CMAKE_BUILD_TYPE "Release")
    set(LIBRARY_OUTPUT_PATH ${PROJECT_SOURCE_DIR}/release)
    set(EXECUTABLE_OUTPUT_PATH ${PROJECT_SOURCE_DIR}/release)

else()

    set(CMAKE_BUILD_TYPE "Debug")
    set(LIBRARY_OUTPUT_PATH ${PROJECT_SOURCE_DIR}/debug)
    set(EXECUTABLE_OUTPUT_PATH ${PROJECT_SOURCE_DIR}/debug)

endif()

find_package(Python3 REQUIRED
             COMPONENTS Interpreter Development)
if(NOT Python3_FOUND)
    message(FATAL "Python3 Environment Not Found")
endif()
include_directories(${Python3_INCLUDE_DIRS})

include_directories(include)

add_executable(sofruner
    ${PROJECT_SOURCE_DIR}/src/find_process.cpp
    ${PROJECT_SOURCE_DIR}/main.cpp
    ${PROJECT_SOURCE_DIR}/icon/sofrunerico.rc
)

add_custom_command(
    TARGET     sofruner
    POST_BUILD
    COMMAND    ${MAKE_COMMAND} -C ${PROJECT_SOURCE_DIR}/py
)

target_link_libraries(sofruner
    ${Python3_LIBRARIES}
)

if(${BUILD_RELEASE})

    install(
        FILES
            ${PROJECT_SOURCE_DIR}/release/sofruner.exe
            ${Python3_RUNTIME_LIBRARY}
        DESTINATION
            ${CMAKE_INSTALL_PREFIX}/bin
    )
    # install bins

    install(
        FILES
            ${PROJECT_SOURCE_DIR}/py/sofruner.pyc
        DESTINATION
            ${CMAKE_INSTALL_PREFIX}/py
    )
    # install py modules

    install(
        FILES
            ${PROJECT_SOURCE_DIR}/config/config.ini
        DESTINATION
            ${CMAKE_INSTALL_PREFIX}/config
    )
    # install config files

    install(
        FILES
            ${PROJECT_SOURCE_DIR}/icon/icon.gif
            ${PROJECT_SOURCE_DIR}/icon/sofrunerico.ico
        DESTINATION
            ${CMAKE_INSTALL_PREFIX}/icon
    )

    install(
        FILES
            ${PROJECT_SOURCE_DIR}/LICENSE
            ${PROJECT_SOURCE_DIR}/start_gui_with_python.bat
            ${PROJECT_SOURCE_DIR}/start_gui_with_python.vbs
        DESTINATION
            ${CMAKE_INSTALL_PREFIX}
    )
    # install other things

endif()