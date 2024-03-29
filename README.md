nRage
===========

A .NET library for searching and retreiving metadata for TV shows and movies. The name comes from TVRage which was the first external API supported by nRage.

*** This is a very low priority - do not be surprised if it's a year or more between major updates ***

History
-------

###v0.2.5 (2013-Jan-14)
+ TheTVDB API support

###v0.2 (2012-Dec-17)
+ TVRage update/scheduling API support

###v0.1 (2012-Dec-15)
+ Initial official release
* TVRage API support

Roadmap
-------

###v0.3
+ Common data model abstraction for TV shows

###v0.4
+ Very basic TheMovieDB and RottenTomatoes support
+ Common data model abstraction for movies

###v0.5
+ Basic local cache 

###v1.0
+ Intelligent configurable local cache
+ nRage documenation

###Low priority but Would Be Nice
+ Refactor web service clients to properly abstract URL generation and web retriever

###Very low priority
+ TVRage TV schedule API
+ TVRage API documentation 

TODO / Notes to self
====================

* Support country attribute for <network> nodes
* Finish in-line XML documentation for contracts
* Proper API documentation (eg: status codes for show list)
* Re-think Stream usage for IRetriever (poor memory management)

TVRage API notes
================

Observed inconsistencies
------------------------

* <ended> sometimes returns either empty/self-terminating or "0"s
* <AKAs> not returned at all if empty; other tags are returned as self-terminating nodes
* API guide indicates EpisodeInfo is retrieved by:

    > http://services.tvrage.com/feeds/episodeinfo.php?show={SHOWNAME}&exact=1&ep={SEASON}x{EPISODE}

  Actual usage is:

    > http://services.tvrage.com/feeds/episodeinfo.php?sid={SHOWId}&ep={SEASON}x{EPISODE}

* LastUpdates does not appear to support the advertised ability to get updates from a specific point in time
* Inconsistent naming (eg sometimes "id" or "name" othertimes "showid" or "showname")
* Inconsistent casing (eg XML for show info opens with "Showinfo" - all other nodes in show info are strict lower case)
* Inconsistent number format (eg: episode number example is 2x05 - leading zero for episode number, no leading zero for season - but both work interchangeably)

TheTVDB API notes
================

Mirror flags:

* None: 0
* Zip, banner and XML: 7

