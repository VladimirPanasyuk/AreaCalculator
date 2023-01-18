Console.WriteLine("select Products.Name, Categories.Name from Products LEFT JOIN Categories on Products.CategorianId = Categories.Id");
Console.ReadKey();

/*
 * Ответ на второй вопрос

    select Products.Name, Categories.Name
    from Products LEFT JOIN Categories on Products.CategorianId = Categories.Id
    --выведет пары имя товара - имя категории, и товары без категории


    select Products.Name, Categories.Name
    from Products FULL JOIN Categories on Products.CategorianId = Categories.Id 
    -- тоже выведет товары без категории, но и еще категории без товаров, если такие имеются
 */