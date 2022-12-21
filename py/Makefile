PYTHON = python
PYTHON_FLAG = -m py_compile

ifeq (${PYTHON_FLAG},-m py_compile)
PYTHON_COMPILED_FILE_FE = pyc
else
PYTHON_COMPILED_FILE_FE = pyo
endif
# filename extension for python compiled file (.pyc or .pyo)

PYTHON_EDITION = cpython-310
# python edition

all:build

build:
	@${PYTHON} ${PYTHON_FLAG} sofruner.py
	@echo ------ Compiling python target: sofruner

	@copy __pycache__\sofruner.${PYTHON_EDITION}.${PYTHON_COMPILED_FILE_FE} sofruner.${PYTHON_COMPILED_FILE_FE}

clean:
	rmdir /s /q __pycache__
	del /q *.${PYTHON_COMPILED_FILE_FE}

help:
	@echo The following are the valid targets for this Makefile:
	@echo ... all:   compile all targets (the default if no target is provided)
	@echo ... build: same as all
	@echo ... clean: delete all compiled python files
	@echo ... help:  show this page