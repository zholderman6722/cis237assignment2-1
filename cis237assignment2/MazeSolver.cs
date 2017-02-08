using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment2
{
    /// <summary>
    /// This class is used for solving a char array maze.
    /// You might want to add other methods to help you out.
    /// A print maze method would be very useful, and probably neccessary to print the solution.
    /// If you are real ambitious, you could make a seperate class to handle that.
    /// </summary>
    class MazeSolver
    {
        /// <summary>
        /// Class level memeber variable for the mazesolver class
        /// </summary>
        char[,] maze;
        int xStart;
        int yStart;

        /// <summary>
        /// Default Constuctor to setup a new maze solver.
        /// </summary>
        public MazeSolver()
        { 
        }


        /// <summary>
        /// This is the public method that will allow someone to use this class to solve the maze.
        /// Feel free to change the return type, or add more parameters if you like, but it can be done
        /// exactly as it is here without adding anything other than code in the body.
        /// </summary>
        public void SolveMaze(char[,] maze, int xStart, int yStart)
        {
            //Assign passed in variables to the class level ones. It was not done in the constuctor so that
            //a new maze could be passed in to this solve method without having to create a new instance.
            //The variables are assigned so they can be used anywhere they are needed within this class. 
            this.maze = maze;
            this.xStart = xStart;
            this.yStart = yStart;

            //Do work needed to use mazeTraversal recursive call and solve the maze.
            //need if statements to track valid movements for down, right, up, left and also to check if maze has been solved.
            printMaze(maze);
        }


        /// <summary>
        /// This should be the recursive method that gets called to solve the maze.
        /// Feel free to change the return type if you like, or pass in parameters that you might need.
        /// This is only a very small starting point.
        /// </summary>
        private void mazeTraversal()
        {
            //Implement maze traversal recursive call 
            //Calls solveMaze to move down
            SolveMaze(maze, xStart--, yStart);

            //Calls solveMaze to move right
            SolveMaze(maze, xStart, yStart++);
            
            //calls solveMaze to move up
            SolveMaze(maze, xStart++, yStart);
            //Calls solve maze to move left
            SolveMaze(maze, xStart, yStart--);
            
        }
        //method to print out a 2d char array called maze
        private void printMaze(char [,] maze)
        {
            for (int i =0; i<= maze.GetLength(0)-1; i++)
            {
                for (int j = 0; j <= maze.GetLength(0)-1; j++)
                {
                    Console.Write( maze[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
