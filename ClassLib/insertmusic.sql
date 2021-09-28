INSERT INTO artists (name) VALUES ('Kanye');
INSERT INTO artists (name) VALUES ('Drake');


INSERT INTO songs (name, album_id, genre, runtime) VALUES ('Off the Grid', 1, 'rap', '4:00');
INSERT INTO songs (name, album_id, genre, runtime) VALUES ('Donda', 1, 'hip-hop','3:52');
INSERT INTO songs (name, album_id, genre, runtime) VALUES ('Champion', 1, 'hip-hop','3:59');
INSERT INTO songs (name, album_id, genre, runtime) VALUES ('5am in Toronto', 2, 'rap','2:55');
INSERT INTO songs (name, album_id, genre, runtime) VALUES ('6am in Toronto', 2, 'hip-hop','4:01');


INSERT INTO albums(name, artist_id) VALUES ('DONDA', 1);
INSERT INTO albums(name, artist_id) VALUES ('Graduation', 1);
INSERT INTO albums(name, artist_id) VALUES ('CLB', 2);


INSERT INTO tracklist(song_id, album_id, artist_id) VALUES (1, 1,1);
INSERT INTO tracklist(song_id, album_id, artist_id) VALUES(2, 1,1);
INSERT INTO tracklist(song_id, album_id, artist_id) VALUES (3, 1,1);
INSERT INTO tracklist(song_id, album_id, artist_id) VALUES (1, 2,2);
INSERT INTO tracklist(song_id, album_id, artist_id) VALUES (2, 2,2);
