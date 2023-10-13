select p.product_name , y.year , y.price  from product p
                    inner join Sales Y on 
                            p.product_id=y.product_id 
                                        order by product_name;
