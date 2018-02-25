# OpenDriveSim

An easy-to-use, accessible driving simulator heavily based off of Udacity's [Self-Driving Simulator.](https://github.com/udacity/self-driving-car-sim)
-----

## Features
 - Depth Data
 
![Raw Image](Docs/original_img.png)
![Depth Image](Docs/depth.png)
 
## Why OpenDriveSim?
Hardware costs too much, and I currently can't interface my systems to real vehicles. This is an easy alternative.

LIDAR and RADAR have their drawbacks, and a simulator like this allows for accurate, high resolution data with little limitations, perfect for training/testing models.

Current driving simulators have lots of drawbacks(low performance, unrealistic, unreliable/glitchy data). This driving sim is designed to be more accessible for people with mid-tier hardware, and is a bit more realistic  & reliable. 

## How to use?
### Collecting Training Data
Select "Training Mode" from the game menu, then click on record to choose a directory. Click record again to begin recording data, and end the recording by toggling it again. You can control the vehicle via an analog joystick (recommended), WASD keys, arrow keys, or mouse/trackpad.

### Testing out your Neural Net
After training your model to output steering and throttle(optional), save your model with a .h5 extension, then use the [drive.py](https://github.com/udacity/CarND-Behavioral-Cloning-P3/blob/master/drive.py) script with the following command:

```python drive.py model_dir.h5 output_dir``` 

output_dir is for outputting image frames of your vehicle driving. If you'd like to create a video from the outputted frames, use [video.py](https://github.com/udacity/CarND-Behavioral-Cloning-P3/blob/master/video.py) with the following command:

```python video.py output_dir ```

and append ```--fps 60``` if you'd like to change the framerate. Default framerate is 60 FPS. 


## Plans/Upcoming features
The simulator is currently at a very early stage. I'm still working on adding a lot more features and improving the simulator.
 - More maps
 - Urban setting w/ signs, traffic lights, other (possibly moving) vehicles
 - Waypoint AI for lazy dataset creation
 - More sensor data (Gyro/accel, GPS-Like data)
 - More ways to control the vehicle
 - Different training/testing modes. The current sim is for behavioral cloning, however I'd like to add a reinforcement learning mode sometime soon.
 - More realistic shaders/post processing
 - Possible extra weather conditions
