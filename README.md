# bigbluebutton-api-dotnet
.NET client for BigBlueButton REST api

BigBlueButton .NET API
https://docs.bigbluebutton.org/dev/api.html#API_

Roadmap:
1. basic api executions (done)
2. sample console client app (done)
3. first release 

| created by Nitin Sawant  |
|------------|
| <img src="https://www.google.com/a/cpanel/nitinsawant.com/images/logo.gif?service=google_gsuite" width="150"> |


Installation instructions
# STEP1
you need to create "A" record in your DNS zone file and point it to your static IP address of server
e.g. 
> A  bbb  10.10.8.8

above record makes bbb.yourdomain.com pointing to your ubuntu server

# STEP 2
SSH to your ubuntu server, login as root user

Install BBB using following command
> sudo wget -qO- https://ubuntu.bigbluebutton.org/bbb-install.sh | sudo bash -s -- -w -v xenial-22 -a -w -g -s bbb.yourdomain.com -e me@yourmail.com

create admin account for greenlight
> cd ~/greenlight
> sudo docker exec greenlight-v2 bundle exec rake user:create["Admin","me@yourmail.com","N00b@123","admin"]

get secret
> bbb-conf --secret

you need to put this secret in the ClsBigBlueButton.cs set the StrSalt property and you're good to go using this API

to renew the certificates(when your free SSL cert expires)
> certbot renew 
