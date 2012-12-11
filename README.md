nRage
===========

A simple .NET wrapper for the TVRage.com API.

TVRage API notes
================
TODO / Notes to self
--------------------
* Support country attribute for <network> nodes
* Finish in-line XML documentation for contracts

Observed inconsistencies
------------------------
* <ended> sometimes returns either empty/self-terminating or "0"s
* <AKAs> not returned at all if empty; other tags are returned as self-terminating nodes
* API guide indicates EpisodeInfo is retrieved by:
	> http://services.tvrage.com/feeds/episodeinfo.php?show={SHOWNAME}&exact=1&ep={SEASON}x{EPISODE}
  Actual usage is:
    > > http://services.tvrage.com/feeds/episodeinfo.php?sid={SHOWID}&ep={SEASON}x{EPISODE}