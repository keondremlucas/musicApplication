SELECT tl.*, s.*, a.*, al.*
FROM tracklist tl
JOIN songs s on s.id = tl.song_id
JOIN artists a on a.id = tl.artist_id
JOIN albums al on al.id = tl.album_id;
-- SELECT tr.*, a.* 
-- FROM tracklist tr
-- JOIN artists a on a.id = tr.artist_id;
