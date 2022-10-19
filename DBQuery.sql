INSERT INTO Users
VALUES ('testSubject','Password123','test@gmail.co,','A person who is test.',GETDATE());

INSERT INTO Thread(Title,UserName,Links,Description,DateCreated,upVotes)
VALUES ('Test Thread','testSubject','https://www.google.com','Check out this cool link',GETDATE(),'5');

INSERT INTO Comments(threadID,txtContent,txtComments,DateCreated,upVotes)
VALUES ('1','This is an amazing thread','I learned so much',GETDATE(),25);