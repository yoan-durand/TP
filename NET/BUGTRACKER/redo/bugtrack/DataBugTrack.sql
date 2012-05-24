INSERT INTO [dbo].[T_Project] (name, version, startDate)
values ('malloc', 1.2, '2013-12-02')

INSERT INTO [dbo].[T_Project] (name, version, startDate)
values ('PLIC', 1.5, '2013-11-14')

INSERT INTO [dbo].[T_User] (name, firstname, email, phone, password)
values ('durand', 'yoan', 'durand.yoan@gmail.com', '0248792586', 'yoan')

insert into [dbo].[T_Bug] (title, idProject, Type, Description, Createdate)
values ('Acces refuse', 1, 0, 'Peut pas ecrire dans chaine de caractere', '2012-12-02')

insert into [dbo].[T_Bug] (title, idProject, Type, Description, Createdate)
values ('Erreur parsing', 2, 1, 'Cannot read the value nodevalue', '2013-12-02')

insert into [dbo].[T_Comment] (idUser, idBug, details)
values (1, 2, 'Parse mais parse pas')

insert into [dbo].[T_Comment] (idUser, idBug, details)
values (1, 1, 'Plante mais mais sans savoir taille de map fucker')

insert into [dbo].[T_Transaction] (idBug, idUser, statut)
values (1,1, 0)

insert into [dbo].[T_Transaction] (idBug, idUser, statut)
values (1, 2, 1)

