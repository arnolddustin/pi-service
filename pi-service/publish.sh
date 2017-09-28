dotnet publish -r linux-arm
scp bin/Debug/netcoreapp2.0/linux-arm/publish/publish.zip pi@raspberrypi:~/service.zip
