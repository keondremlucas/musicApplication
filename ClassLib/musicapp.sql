CREATE TABLE artists (
    id integer PRIMARY KEY AUTOINCREMENT,
    name varchar(10)
);

CREATE TABLE songs (
    id integer PRIMARY KEY AUTOINCREMENT,
    name varchar(10),
    album_id integer,
    genre varchar(10),
    runtime varchar(6),
    FOREIGN KEY(album_id) REFERENCES album(id)

);

CREATE TABLE albums (
    id integer PRIMARY KEY AUTOINCREMENT,
    name varchar(10),
    artist_id integer,
    FOREIGN KEY(artist_id) REFERENCES artists(id)
);

CREATE TABLE tracklist(
    id integer PRIMARY KEY AUTOINCREMENT,
    song_id integer,
    album_id integer,
    artist_id integer,
    FOREIGN KEY (song_id) REFERENCES songs(id),
    FOREIGN KEY (album_id)  REFERENCES albums(id),
    FOREIGN KEY (artist_id) REFERENCES artists(id)
);


