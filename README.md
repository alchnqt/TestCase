<h1>.NET 5.0</h1>
<a href = "https://github.com/alcohon/TestCase/blob/master/README_RU_RU.md">Ru documentation</a><br/>
System requirements
<ol>
  <li>Windows 10</li>
  <li>.NET 5.0</li>
</ol>
<p><b>Console pizza delivery robot</b><br/>
User guide:<br/>
  It's console app that reads data from <b>command line arguments</b>, so that input data should be like, e.g.,<br/>
5x5 (0, 0) (1, 3) (4, 4) (4, 2) (4, 2) (0, 1) (3, 2) (2, 3) (4, 1)<br/>
3x4 (1, 3) (2, 3)<br/>
2x4 (1, 0)<br/>
where is 5x5 etc is map size: height x width  <br/>
and the other are pizza delivery points (x, y) x,y - coordinates<br/>
Robot can move to any part of the world: East, West, North, South, and Drop pizza to needed point, <br/>
so output would be like EDEEEDSSEED, where E(East), D(Drop), S(South) resp.<br/>
Unit-testing included<br/>
</p>
