#!/usr/bin/perl
 
@months = qw(Jan Feb Mar Apr May Jun Jul Aug Sep Oct Nov Dec);
@weekDays = qw(Sun Mon Tue Wed Thu Fri Sat Sun);
($second, $minute, $hour, $dayOfMonth, $month, $yearOffset, $dayOfWeek, $dayOfYear, $daylightSavings) = localtime();
$year = 1900 + $yearOffset;
$theTime = "$weekDays[$dayOfWeek] $months[$month] $dayOfMonth, $year";
 
print "Content-type: text/html\n\n";
print <<HTML;
<html>
<head>
<title>A Simple Perl CGI</title>
</head>
<body>
<h1>A Simple Perl CGI</h1>
<p>$theTime</p>
</body>
HTML
exit;

 
