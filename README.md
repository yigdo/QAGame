# Question And Answer Game
![Badge](https://img.shields.io/static/v1?label=VERY&message=Useless&color=blueviolet?style=for-the-badge&logo=appveyor)
![Badge](https://img.shields.io/static/v1?label=Why%20Did%20I&message=Spent%20Time%20For%20That&color=red)

This game was a sideproject for me who wanted to build a fun app! This QA Game is originally designed for testing trivia knowledge but later decided that no one is going to play a game like this. You can configure the code if you want to modify and create your own levels.

## Creating Levels

Inside of the QuestionBase.cs under the folder `data` you can find the configuration of levels and questions. In this step you will work with 3 different classes:

- Level
- Question
- Answer

The relationship between this classes  is **Levels** has many **Questions** that has many **Answers**. You can create your own level under the list `levels`. This data is similar to entity framework because of Linq. ex: 
```c#
 _questionBase.levels.FirstOrDefault(x => x.Id == _state.LevelIndex.ToString()
 ```

Inside of that list you will find levels. Create one! You will need to specify the lenght. The lenght should be accurate because my big brain decided to not use the built-in features by generic collections but to depend on user for that information. Now that everything is built, I cannot change my mistakes.

Every question has answers. We recommend not to create more answers that 4. This is supposed to be a fun game, not a reading practice. You can specify one correct answer from the props of question class. You will need to enter the index value of the answer to that prop.

