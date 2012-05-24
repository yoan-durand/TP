INSERT INTO [dbo].[T_Project] (name, version, startDate)
values ('malloc', 1.2, '2013-12-02')

INSERT INTO [dbo].[T_User] (name, firstname, email, phone, password)
values ('durand', 'yoan', 'durand.yoan@gmail.com', '0248792586', 'yoan')

insert into [dbo].[T_Bug] (title, idProjet, Type, Description, Createdate)
values ('Acces refuse', 1, 'Segfault', 'Peut pas ecrire dans chaine de caractere', '2012-12-02')

insert into [dbo].[T_Comment] (idUser, idBug, details)
values (1, 1, 'Plante mais mais sans savoir taille de map fucker')

insert into [dbo].[T_Transaction] (idBug, idUser, statut)
values (1,1, 'En cours de traitement')