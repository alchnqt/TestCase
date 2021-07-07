<h1>.NET 5.0</h1>
[Ru documentation]: https://github.com/alcohon/TestCase/blob/master/README_RU_RU.md
<p><b>Console pizza delivery robot</b><br/>
User guide:
It's console app that reads data from command line arguments, so that input data should be like, e.g.,
5x5 (0, 0) (1, 3) (4, 4) (4, 2) (4, 2) (0, 1) (3, 2) (2, 3) (4, 1)
3x4 (1, 3) (2, 3)
2x4 (1, 0)
where is 5x5 etc is map size: height x width  
and the other are pizza delivery points (x, y) x,y - coordinates
Robot can move to any part of the world: East, West, North, South, and Drop pizza to needed point, 
so output would be like EDEEEDSSEED, where E(East), D(Drop), S(South) resp.
Unit-testing included
</p>
