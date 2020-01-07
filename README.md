# Coding-Challeges

# Tik Tac Toe console game.

The program consist of Tic_Tac_Toe class.

consist of fields 1. two dimentional int array
                  2. playername
properites 1. Player 
           2. PlayerName 
           
methods : 
initBoard() : intitialize the 3x3 board.
drawBoard() : Draw the board for current user.
playGame()  : logic for game.

# other private methods
win()       : check if the game has won.
draw()      : check if the game is draw.
chkInput()  : check for valid inputs. show error message to user.

# How to Play

1. Both user has to Enter a valid name(string)
2. user will be asked to enter a postition to enter a choice
3. user should enter a valid input in the foramt of matrix[3,3]
e.g 
    0 0 0
    0 0 0 
    0 0 0
    
input: 1                    ---> row number
       1                    ---> coloumn number
output: 1 0 0 
        0 0 0 
        0 0 0
        
# Note
 
 Works only for two user inputs.
