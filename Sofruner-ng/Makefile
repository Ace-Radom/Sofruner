MSBUILD = msbuild

MSBUILD_TARGET 		       = Sofruner-ng.sln
MSBUILD_FLAG_REBUILD       = /t:Rebuild
MSBUILD_FLAG_CLEAN         = /t:Clean
MSBUILD_FLAG_BUILD_DEBUG   = /p:Configuration=Debug
MSBUILD_FLAG_BUILD_RELEASE = /p:Configuration=Release

all:build-debug

rebuild:rebuild-debug

build-debug:
	@${MSBUILD} ${MSBUILD_TARGET} /nologo ${MSBUILD_FLAG_BUILD_DEBUG}

build-release:
	@${MSBUILD} ${MSBUILD_TARGET} /nologo ${MSBUILD_FLAG_BUILD_RELEASE}

rebuild-debug:
	@${MSBUILD} ${MSBUILD_TARGET} /nologo ${MSBUILD_FLAG_REBUILD} ${MSBUILD_FLAG_BUILD_DEBUG}

rebuild-release:
	@${MSBUILD} ${MSBUILD_TARGET} /nologo ${MSBUILD_FLAG_REBUILD} ${MSBUILD_FLAG_BUILD_RELEASE}

clean:
	@${MSBUILD} ${MSBUILD_TARGET} /nologo ${MSBUILD_FLAG_CLEAN} ${MSBUILD_FLAG_BUILD_DEBUG}
	@${MSBUILD} ${MSBUILD_TARGET} /nologo ${MSBUILD_FLAG_CLEAN} ${MSBUILD_FLAG_BUILD_RELEASE}

help:
	@echo The following are the valid targets for this Makefile:
	@echo ... all:             same as build-debug
	@echo ... build-debug:     compile Sofruner-ng for debug
	@echo ... build-release:   compile Sofruner-ng for release
	@echo ... rebuild:         same as rebuild-debug
	@echo ... rebuild-debug:   re-compile Sofruner-ng for debug
	@echo ... rebuild-release: re-compile Sofruner-ng for release
	@echo ... clean:           clean all files created by commpiler
	@echo ... help:            show this page