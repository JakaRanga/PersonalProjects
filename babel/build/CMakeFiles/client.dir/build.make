# CMAKE generated file: DO NOT EDIT!
# Generated by "Unix Makefiles" Generator, CMake Version 3.9

# Delete rule output on recipe failure.
.DELETE_ON_ERROR:


#=============================================================================
# Special targets provided by cmake.

# Disable implicit rules so canonical targets will work.
.SUFFIXES:


# Remove some rules from gmake that .SUFFIXES does not remove.
SUFFIXES =

.SUFFIXES: .hpux_make_needs_suffix_list


# Suppress display of executed commands.
$(VERBOSE).SILENT:


# A target that is always out of date.
cmake_force:

.PHONY : cmake_force

#=============================================================================
# Set environment variables for the build.

# The shell in which to execute make rules.
SHELL = /bin/sh

# The CMake executable.
CMAKE_COMMAND = /usr/bin/cmake

# The command to remove a file.
RM = /usr/bin/cmake -E remove -f

# Escaping for special characters.
EQUALS = =

# The top-level source directory on which CMake was run.
CMAKE_SOURCE_DIR = /home/jakaresse/delivery/Cpp/CPP_babel_2018

# The top-level build directory on which CMake was run.
CMAKE_BINARY_DIR = /home/jakaresse/delivery/Cpp/CPP_babel_2018/build

# Include any dependencies generated for this target.
include CMakeFiles/client.dir/depend.make

# Include the progress variables for this target.
include CMakeFiles/client.dir/progress.make

# Include the compile flags for this target's objects.
include CMakeFiles/client.dir/flags.make

CMakeFiles/client.dir/gui_src/main.cpp.o: CMakeFiles/client.dir/flags.make
CMakeFiles/client.dir/gui_src/main.cpp.o: ../gui_src/main.cpp
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --progress-dir=/home/jakaresse/delivery/Cpp/CPP_babel_2018/build/CMakeFiles --progress-num=$(CMAKE_PROGRESS_1) "Building CXX object CMakeFiles/client.dir/gui_src/main.cpp.o"
	/usr/bin/c++  $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -o CMakeFiles/client.dir/gui_src/main.cpp.o -c /home/jakaresse/delivery/Cpp/CPP_babel_2018/gui_src/main.cpp

CMakeFiles/client.dir/gui_src/main.cpp.i: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Preprocessing CXX source to CMakeFiles/client.dir/gui_src/main.cpp.i"
	/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -E /home/jakaresse/delivery/Cpp/CPP_babel_2018/gui_src/main.cpp > CMakeFiles/client.dir/gui_src/main.cpp.i

CMakeFiles/client.dir/gui_src/main.cpp.s: cmake_force
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green "Compiling CXX source to assembly CMakeFiles/client.dir/gui_src/main.cpp.s"
	/usr/bin/c++ $(CXX_DEFINES) $(CXX_INCLUDES) $(CXX_FLAGS) -S /home/jakaresse/delivery/Cpp/CPP_babel_2018/gui_src/main.cpp -o CMakeFiles/client.dir/gui_src/main.cpp.s

CMakeFiles/client.dir/gui_src/main.cpp.o.requires:

.PHONY : CMakeFiles/client.dir/gui_src/main.cpp.o.requires

CMakeFiles/client.dir/gui_src/main.cpp.o.provides: CMakeFiles/client.dir/gui_src/main.cpp.o.requires
	$(MAKE) -f CMakeFiles/client.dir/build.make CMakeFiles/client.dir/gui_src/main.cpp.o.provides.build
.PHONY : CMakeFiles/client.dir/gui_src/main.cpp.o.provides

CMakeFiles/client.dir/gui_src/main.cpp.o.provides.build: CMakeFiles/client.dir/gui_src/main.cpp.o


# Object files for target client
client_OBJECTS = \
"CMakeFiles/client.dir/gui_src/main.cpp.o"

# External object files for target client
client_EXTERNAL_OBJECTS =

client: CMakeFiles/client.dir/gui_src/main.cpp.o
client: CMakeFiles/client.dir/build.make
client: /usr/lib/x86_64-linux-gnu/libboost_filesystem.a
client: /usr/lib/x86_64-linux-gnu/libboost_system.a
client: CMakeFiles/client.dir/link.txt
	@$(CMAKE_COMMAND) -E cmake_echo_color --switch=$(COLOR) --green --bold --progress-dir=/home/jakaresse/delivery/Cpp/CPP_babel_2018/build/CMakeFiles --progress-num=$(CMAKE_PROGRESS_2) "Linking CXX executable client"
	$(CMAKE_COMMAND) -E cmake_link_script CMakeFiles/client.dir/link.txt --verbose=$(VERBOSE)

# Rule to build all files generated by this target.
CMakeFiles/client.dir/build: client

.PHONY : CMakeFiles/client.dir/build

CMakeFiles/client.dir/requires: CMakeFiles/client.dir/gui_src/main.cpp.o.requires

.PHONY : CMakeFiles/client.dir/requires

CMakeFiles/client.dir/clean:
	$(CMAKE_COMMAND) -P CMakeFiles/client.dir/cmake_clean.cmake
.PHONY : CMakeFiles/client.dir/clean

CMakeFiles/client.dir/depend:
	cd /home/jakaresse/delivery/Cpp/CPP_babel_2018/build && $(CMAKE_COMMAND) -E cmake_depends "Unix Makefiles" /home/jakaresse/delivery/Cpp/CPP_babel_2018 /home/jakaresse/delivery/Cpp/CPP_babel_2018 /home/jakaresse/delivery/Cpp/CPP_babel_2018/build /home/jakaresse/delivery/Cpp/CPP_babel_2018/build /home/jakaresse/delivery/Cpp/CPP_babel_2018/build/CMakeFiles/client.dir/DependInfo.cmake --color=$(COLOR)
.PHONY : CMakeFiles/client.dir/depend

