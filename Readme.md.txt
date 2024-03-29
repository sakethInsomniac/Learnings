Your task is to write a CLI application to parse commands and display the result.

Suppose you have a robot that can receive commands in order to move it.  These commands will tell the robot to go forwards or backwards, and turn left or right.  These commands will be  in the format <command><number>.  For example 'L1' means 'turn left by 90 degrees once'.  'B2' would mean go backwards 2 units.

### Available commands:
* `F` - move forward 1 unit
* `B` - move backward 1 unit
* `R` - turn right 90 degrees
* `L` - turn left 90 degrees

### Your task
Write a program that receives a string of commands and will output the robot's distance from it's starting point.  This distance will be the minimum amount of units the robot will need to traverse in order to get back to it's starting point.  Remember, the robot can only turn 90 degrees at a time, so it cannot go directly back home, it must go in north, south, east, west directions.

Inputs: - a string of comma-separated commands eg `F1,R1,B2,L1,B3`
Output: - the minimum amount of distance to get back to the starting point (`4` in this case)

The specifics and implementation of this code is completely up to you!  The input could be a string, a filename with the commands as contents or anything else.