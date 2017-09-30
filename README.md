# pi-service
ASPNET Core website that exposes features of the [pi-dotnetcore](https://www.github.com/arnolddustin/pi-dotnetcore) library as a RESTful service.

# getting started
* clone this repostory
* run the `publish.sh` script to build and deploy.  The script builds the dotnetcore app for the linux-arm platfrom then uses `rsync` to copy the built output to a pie listening at at the login/host `pi@raspberrypi`.

# running on the pi
* run `publish.sh` to publish to the pi
* `ssh` to the pi
* change to the `pi-service` directory
* start the service by running `sudo ./pi-service &`
