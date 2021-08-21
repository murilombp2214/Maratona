SELECT movies.id,
       movies.name
FROM movies
    INNER JOIN genres ON
        (genres.id = movies.id_genres
         and genres.description = 'Action'
         )