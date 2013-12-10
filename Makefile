
NUNIT_BIN = "C:/Program Files (x86)/NUnit 2.6.1/bin"


test:
	scons
	${NUNIT_BIN}/nunit-console.exe tests/libsTest.dll
