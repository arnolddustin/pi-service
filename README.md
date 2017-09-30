# pi-service
ASPNET Core website that exposes features of the [pi-dotnetcore](https://www.github.com/arnolddustin/pi-dotnetcore) library as a RESTful service.

# publishing
The `publish.sh` script builds the console app and uses `rsync` to copy the built output to a pie with hostname `raspberrypi` and user `pi`.

# running on the pi
* run `publish.sh` to publish to the pi
* `ssh` to the pi
* change to the `pi-service` directory
* start the service by running `sudo ./pi-service &`
