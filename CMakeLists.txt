cmake_minimum_required(VERSION 3.10)
project(sofruner VERSION 1.0)

set(CMAKE_CXX_STANDARD_REQUIRED ON)
set(CMAKE_CXX_STANDARD 14)

set(CMAKE_INSTALL_PREFIX ${CMAKE_SOURCE_DIR}/release_package)

set(BUILD_RELEASE OFF)

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

add_executable(sofruner
    ${PROJECT_SOURCE_DIR}/main.cpp
)

target_link_libraries(sofruner
    ${Python3_LIBRARIES}
)

if(${BUILD_RELEASE})

    install(
        
    )

endif()