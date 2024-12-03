//*****************************************************************************
//** 2109. Adding Spaces to a String    leetcode                             **
//*****************************************************************************

char* addSpaces(char* s, int* spaces, int spacesSize)
{
    int len = strlen(s);
    char* result = (char*)malloc((len + spacesSize + 1) * sizeof(char));
    int resIndex = 0;
    int spaceIndex = 0; 

    for (int i = 0; i < len; i++)
    {
        if (spaceIndex < spacesSize && spaces[spaceIndex] == i)
        {
            result[resIndex++] = ' ';
            spaceIndex++;
        }
        result[resIndex++] = s[i];
    }

    result[resIndex] = '\0'; 
    return result;
}