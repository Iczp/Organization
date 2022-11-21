--select  *  from [10.20.5.179].[dwkit330].[dbo].[RC_Base_Area]


-------------------------------------
INSERT INTO [dbo].[Organization_PostType]  ([Id],[Name],[Code],[IsActive],[Sorting],[IsStatic],[CreationTime]) 
SELECT [Id],[Name],[Code],[IsEnabled],
--Sort
case when [Sort] is null  then 0
else  [Sort] end
,0,[CreateTime]
FROM [10.20.5.179].[dwkit330].[dbo].[RC_Organization_PostType] b
where  b.id not in (select id from [dbo].[Organization_PostType])
--delete [dbo].[Organization_PostType]
--select * from [dbo].[Organization_PostType]
------------------

INSERT INTO [dbo].[Organization_PostRank]  ([Id],[Name],[Code],[PostTypeId],[IsActive],[Sorting],[IsStatic],[CreationTime]) 
SELECT [Id],[Name],[Code],[PostTypeId],
--[IsEnabled]
case when [IsEnabled] is null  then 0 else  [IsEnabled] end
,
--Sort
case when [Sort] is null  then 0 else  [Sort] end
,0,[CreateTime]
FROM [10.20.5.179].[dwkit330].[dbo].[RC_Organization_PostRank] b
where  b.id not in (select id from [dbo].[Organization_PostRank])
-----------------------------------


INSERT INTO [dbo].[Organization_PostGrade]  ([Id],[Name],[Code],[PostRankId],[PostLevelId],[Value],[IsActive],[Sorting],[IsStatic],[CreationTime]) 
SELECT [Id],[Name],[Code],[PostRankId],[PostLevelId],
--[value]
--select top 1 sort from  [10.20.5.179].[dwkit330].[dbo].[RC_Organization_PostLevel] L where L.id=b.PostLevelId
0
,
--[IsEnabled]
case when [IsEnabled] is null  then 0 else  [IsEnabled] end
,
--Sort
case when [Sort] is null  then 0 else  [Sort] end
,0,
--[CreateTime]
case when [CreateTime] is null  then '2022-02-22 22:22:22' else  [CreateTime] end
FROM [10.20.5.179].[dwkit330].[dbo].[RC_Organization_PostGrade] b
where  b.id not in (select id from [dbo].[Organization_PostGrade])
--delete [dbo].[Organization_PostGrade] 
-- select * from [dbo].[Organization_PostGrade] 


-----------------------------------
--PostLevel
INSERT INTO [dbo].[Organization_PostLevel]  ([Id],[Name],[Code],[Value],[IsActive],[Sorting],[IsStatic],[CreationTime]) 
SELECT [Id],[Name],[Code],0,
--[IsEnabled]
case when [IsEnabled] is null  then 0 else  [IsEnabled] end
,
--Sort
case when [Sort] is null  then 0 else  [Sort] end
,0,
--[CreateTime]
case when [CreateTime] is null  then '2022-02-22 22:22:22' else  [CreateTime] end
FROM [10.20.5.179].[dwkit330].[dbo].[RC_Organization_PostLevel] b
where  b.id not in (select id from [dbo].[Organization_PostLevel])


--Position
INSERT INTO [dbo].[Organization_Position]  ([Id],[Name],[Code],[IsActive],[Depth],[Sorting],[IsStatic],[FullPath],[FullPathName],[CreationTime],[IsSecretary]) 
SELECT [Id],[Name],[Code],[IsEnabled],0,
--Sort
case when [Sort] is null  then 0
else  [Sort] end
,0,'','',
(case when [CreateTime] is null  then '2022-02-22 22:22:22'
else  [CreateTime] end) 
,0
FROM [10.20.5.179].[dwkit330].[dbo].[RC_Organization_Position] b
where  b.id not in (select id from [dbo].[Organization_Position])

-- delete [dbo].[Organization_Position]
-- select * from [dbo].[Organization_Position]
------------------------------------





INSERT INTO [dbo].[Organization_Functional]  ([Id],[Name],[Code],[IsActive],[Depth],[Sorting],[IsStatic],[FullPath],[FullPathName],[CreationTime]) 
SELECT [Id],[Name],[Code],[IsEnabled],0,
--Sort
case when [Sort] is null  then 0
else  [Sort] end
,0,'','',
(case when [CreateTime] is null  then '2022-02-22 22:22:22'
else  [CreateTime] end) 
FROM [10.20.5.179].[dwkit330].[dbo].[RC_Organization_Functional] b
where  b.id not in (select id from [dbo].[Organization_Functional])

-- delete [dbo].[Organization_Functional]
-- select * from [dbo].[Organization_Functional]
------------------
--Company
INSERT INTO [dbo].[Organization_Company]  ([Id],[Name],[Depth],[Sorting],[IsStatic],[FullPath],[FullPathName],[CreationTime]) 
SELECT [Id],[Name],0,0,0,'','',
(
case when [CreateTime] is null  then '2022-02-22 22:22:22'
else  [CreateTime] end
) as CreateTime
FROM [10.20.5.179].[dwkit330].[dbo].[RC_Organization_Company] b
where  b.id not in (select id from [dbo].[Organization_Company])



----------------------------------------------------------
INSERT INTO [dbo].[Organization_DepartmentType]  ([Id],[Name],[Sorting],[IsStatic],[CreationTime]) 
SELECT [Id],[Name],0,0,[CreateTime]
FROM [10.20.5.179].[dwkit330].[dbo].[RC_Organization_DepartmentType] b
where  b.id not in (select id from [dbo].[Organization_DepartmentType])

-----------------------------------------

--update [dbo].[Organization_DepartmentType] set parentId=(
--select ParentId FROM [10.20.5.179].[dwkit330].[dbo].[RC_Organization_DepartmentType] b 
--where  parentId is not null and  b.Id = [dbo].[Organization_DepartmentType].id)



--select * from [10.20.5.179].[dwkit330].[dbo].[RC_Organization_DepartmentType] where id in 
--(select ParentId from [10.20.5.179].[dwkit330].[dbo].[RC_Organization_DepartmentType] where parentId is not null)
------------------------------------------

INSERT INTO [dbo].[Organization_Department]  ([Id],[ParentId],[DepartmentTypeId],[Name],[FullPathName],[FullPath],[Depth],[Sorting],[CreationTime]) 
SELECT [Id],[ParentId],[DepartmentTypeId],[Name],'','',0,0,[CreateTime]
FROM [10.20.5.179].[dwkit330].[dbo].[RC_Organization_Department] b
where  b.id not in (select id from [dbo].[Organization_Department])




-- select * from [dbo].[Organization_DepartmentType]

-- select * from [dbo].[Organization_Department]

-- delete [dbo].[Organization_Department]

-- delete [dbo].[Organization_DepartmentType]



--Employee

INSERT INTO [dbo].[Organization_Employee]  ([Id],[Name],[Code],[DepartmentId],[IsActive],[Sorting],[IsStatic],[CreationTime]) 

SELECT [Id],[Name],[EmployeeNo],[DepartmentId],
--[IsEnabled]
case when [IsEnabled] is null  then 0 else  [IsEnabled] end
,
--Sort
case when [Sort] is null  then 0 else  [Sort] end
,0,
--[CreateTime]
case when [CreateTime] is null  then '2022-02-22 22:22:22' else  [CreateTime] end
FROM [10.20.5.179].[dwkit330].[dbo].[T_HR_Employee] b
where  b.id not in (select id from [dbo].[Organization_Employee])
--delete [dbo].[[Organization_Employee]] 
-- select * from [dbo].[Organization_Employee]



----------------[PositionId]
INSERT INTO [dbo].[Organization_EmployeePosition] ([EmployeeId],[PositionId],[CreationTime],[Sorting],[IsMaster])

SELECT [Id],[PositionId],
--[CreateTime]
case when [CreateTime] is null  then '2022-02-22 22:22:22' else  [CreateTime] end
,
--Sort
case when [Sort] is null  then 0 else  [Sort] end
,
0

FROM [10.20.5.179].[dwkit330].[dbo].[T_HR_Employee] b
where  b.id not in (select [EmployeeId] from [dbo].[Organization_EmployeePosition])
and b.[PositionId]  is not null
and b.[PositionId] in (select Id from [dbo].[Organization_Position])

-- select * from [dbo].[Organization_EmployeePosition]