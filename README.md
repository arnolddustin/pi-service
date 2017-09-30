# pi-service
Experimenting with dotnetcore on the Raspberry Pi

# publishing
The `publish.sh` script builds the console app and uses `rsync` to copy the built output to a pie with hostname `raspberrypi` and user `pi`.

# running on the pi
* run `publish.sh` to publish to the pi
* `ssh` to the pi
* change to the `pi-service` directory
* start the service by running `./pi-service`
