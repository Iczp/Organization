select  *  from [10.20.5.179].[dwkit330].[dbo].[RC_Base_Area]




INSERT INTO [dbo].[Organization_DepartmentType]  ([Id],[Name],[Sorting],[IsStatic],[CreationTime]) 
SELECT [Id],[Name],0,0,[CreateTime]
FROM [10.20.5.179].[dwkit330].[dbo].[RC_Organization_DepartmentType] b
where  b.id not in (select id from [dbo].[Organization_Department])


INSERT INTO [dbo].[Organization_Department]  ([Id],[ParentId],[DepartmentTypeId],[Name],[FullPathName],[FullPath],[Depth],[Sorting],[CreationTime]) 
SELECT [Id],[ParentId],[DepartmentTypeId],[Name],'','',0,0,[CreateTime]
FROM [10.20.5.179].[dwkit330].[dbo].[RC_Organization_Department] b
where  b.id not in (select id from [dbo].[Organization_Department])







--select * from [dbo].[Organization_Department]

--delete [dbo].[Organization_Department]

--delete [dbo].[Organization_DepartmentType]