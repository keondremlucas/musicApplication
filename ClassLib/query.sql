SELECT alb.*, s.*
FROM albums WHERE name LIKE "CLB"
JOIN songs s on s.id = alb.album_id;
SELECT count(*);
