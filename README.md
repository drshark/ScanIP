# ScanIP
C# ScanIP - TCP port scanner and ping Windows form application.

# Features

1) Scan by IP address or Domain Name.
2) Chose ping or port scan method.
3) Choose start and finish ports or specific ports.
4) Choose timeout connections.
5) Banner/Website header grabbing similar to zenmap/Nmap.
6) Website webpage title grabber.

# Usage
You have to specific and IP adress or a domain name (ex. 192.168.0.1 or www.google.it) in the Addres options.
For IP adressess you can use '#' char to search for a range (ex. 192.168.#.#).
When '#' is used you have to insert Min value and Max value for the range in the Addres options.
Select which method do you need:
- Ping for ICMP echo request.
- Port scanner for scanning one or more ports.
If  Port scanner is selected you can use "Port range" or "Specific ports":
- Port range: are two valid numbers separated from a '-' char (ex. 0-2000).
- Specific ports: any valid numbers for port scan with a separator (ex. 21, 22, 80, 443 or 21; 22; 80; 443)
Use a valid timeout in "General options" in milliseconds. WARNING: a low timeout may fail the check.

# Plans for the future
- Add save settings on exit
- Add save log and results on files
- Add other usefull functions

# Credits and special thanks
Portion code for ports scanner is based on code by Philip Murray. Thank you Philip. Checks his work here (https://github.com/PhilipMur/C-Sharp-Multi-Threaded-Port-Scanner)

Dr. Shark
