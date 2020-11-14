# שבוע רביעי - שאלה 1
###
## לקחתי את הסצנה שיצרנו בשיעור - עם הפ'צר של המגן ומימשתי את סעיף 3
*החללית של השחקן לא נהרסת מייד כשהוא מתנגש באויב, אלא יש לו בתחילת המשחק 3"נקודות פגיעה" (hit points), כל פגיעה באויב מורידה לו נקודה אחת, ורק כשהוא מגיע לאפס הוא נהרס*


<a href="https://ibb.co/W2w6dz1"><img src="https://i.ibb.co/715XTpF/spaceship-game.png" alt="spaceship-game" border="0"></a>


###
## :השינויים שביצעתי עם לינקים לקוד    
1. [הוספתי לסקריפט הקיים פונקצייה שמחזירה את התגית של האובייקט](https://github.com/Lba-universe/SpaceShips-A3-Changes/blob/main/Assets/Scripts/3-collisions/DestroyOnTrigger2D.cs)

2. [ הוספתי סקריפט שמאפשר להוסיף טקסט לאובייקט מסוג זהה (textmashpro) בדומה לסקריפט שנלמד בשיעור על הוספת מספר לתצוגה](https://github.com/Lba-universe/SpaceShips-A3-Changes/blob/main/Assets/Scripts/3-text/TextField.cs)

3. [יצרתי סקריפט שמגדיר לחללית כמות חיים מ1 עד 10 - ערך דיפולטיבי 3 כפי שהוגדר במשימה, בנוסף אני משיג את הסקריפט הקיים שהורס את החללית מבטל אותו ובכל התנגשות אני מחסיר מכמות החיים הנוכחית של החללית במידה והיא הגיעה ל1 אני מחזיר את הסקריפט שהורס את החללית - ככה שבהתנגשות הבאה היא תהרס  ](https://github.com/Lba-universe/SpaceShips-A3-Changes/blob/main/Assets/Scripts/3-collisions/healthDecreaseOnTrigger.cs)

4.[כעת המטרה העיקרית הייתה לקשר בין משתנה החיים של החללית לטקסט שיוצג על המסך שכל אחד מהם נמצא באובייקט אחר לכן היה עלי ליצור סקריפט שיחבר בין הדברים מזהה את השחקן דרך התגית ומשיג את המשתנה ששומר את החיים של החללית ובצורה הזאת מפעיל את הסקריפט שאחראי להדפיס טקסט](https://github.com/Lba-universe/SpaceShips-A3-Changes/blob/main/Assets/Scripts/3-Adapders/PrintHealthPoints.cs) 
 
###
## :איך הכל מתחבר
יצרתי אובייקט מסוג textmashpro
שעליו צירפתי את הסקריפטים הבאים שמוספרו
2,4

לחללית וידאתי שיש לה תגית של Player 
שבעזרתו אני משיג את האובייקט של החללית מסקריפט חיצוני
ובנוסף לאותו אובייקט של החללית צירפתי את הסקריפט הממוספר
3
###
## [קישור למשחק](https://lba-universe.itch.io/spaceship-game)
