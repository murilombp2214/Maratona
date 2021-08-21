SELECT products.id,
       products.name
FROM products
    INNER JOIN categories ON
        (categories.name like 'super%'
            and categories.id = products.id_categories)