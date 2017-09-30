# pi-service
ASPNET Core website that exposes features of the [pi-dotnetcore](https://www.github.com/arnolddustin/pi-dotnetcore) library as a RESTful service.

# getting started
* clone this repostory: `git clone https://github.com/arnolddustin/pi-service.git`
* configure your Raspberry Pi for running dotnet.  full instructions [can be found here](https://github.com/arnolddustin/pi-dotnetcore#getting-started-guide).
* build the service and deploy it to the Raspberry Pi by running the publish script: `./publish.sh`. The script builds the dotnetcore 2.0 app for the **linux-arm platform** then uses `rsync` to copy the build output to a Pi listening at at the login/host `pi@raspberrypi`.

# running on the pi
* after
* `ssh` to the pi
* change to the `pi-service` directory
* start the service by running `sudo ./pi-service &`
