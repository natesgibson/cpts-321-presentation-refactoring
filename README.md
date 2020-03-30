# CPTS 321 - Coding Demo for Refactorings Presentation

## Presentation Group Members
* Mykhailo Bykhovtsev (mykhailo.bykhovtsev@wsu.edu)
* Nathanael Gibson (nathanael.gibson@wsu.edu)
* Odeysiuss Tuon (odeysiuss.tuon@wsu.edu)
* Peyton Urquhart (peyton.urquhart@wsu.edu)
* Alexander Castillo (alexander.castillo@wsu.edu)
* Pengyu Chen (pengyu.chen@wsu.edu)

The main idea of this program is to organize different types of shapes into a collection, with the intention of identifying data about the collection, such as the total sum of the area of all the shapes.

For the brevity and purposes of the coding demo, the only shapes are: Square, Rectangle, and Circle. The repository contains both the unrefactored version and the refactored version, but based on the definition of refactoring, **they should function identically.** The changes would only be for readability and improving structure of the code.

The structure of the CSV file which the program reads is as follows:
* Can contain any amount of shapes of these three types:
    * Circles
        * ```circle,radius```
    * Squares
        * ```square,sideLength```
    * Rectangles
        * ```rectangle,width,height```
* The properties after the name of the shape are positive integers. We can assume that the CSV file will be properly formatted to follow this format.