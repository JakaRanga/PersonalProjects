cmake_minimum_required(VERSION 3.0)

project(client_babel)

set(GUISRCS
        gui_src/main.cpp)

set(GUIHDRS
        )

if (WIN32)
    message("Not yet dude")
endif()

if (UNIX)
    set(CMAKE_CXX_STANDARD 11)
    set(CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} -std=c++11")
    set(Boost_USE_STATIC_LIBS ON)
    set(Boost_USE_MULTITHREADED ON)
    set(Boost_USE_STATIC_RUNTIME ON)
    find_package(Boost 1.62.0 COMPONENTS filesystem)

    if (Boost_FOUND)
        include_directories(${Boost_INCLUDE_DIRS})
        add_executable(client ${GUISRCS} ${GUIHDRS})
        target_link_libraries(client ${Boost_LIBRARIES})
    else()
        message("failed")
    endif()
endif()


