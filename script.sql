--drop table Evento
go
/****** Object:  Table [ans].[Evento]    Script Date: 24/06/2020 20:11:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [Evento](
    [Id] [int] NOT NULL identity(1,1),
	[Timestamp] [float] NULL,
	[Tag] [varchar](100) NOT NULL,
	[Valor] [varchar](100) NOT NULL,
	--[NumeroEvento] [int] NULL,
	--[Timestamp] [timestamp] NULL,
 CONSTRAINT [PK_Evento] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) --ON [PRIMARY]
GO

/*
select *
from Evento

--alter table Evento alter column [Timestamp]  double

delete Evento

select t.Regiao, sum(t.Qtd) [Total de Eventos]
from (
		--select substring(tag,CHARINDEX('.',tag)+1, CHARINDEX('sensor',tag)-9) Regiao, count(*) Qtd
		select substring(tag,0, CHARINDEX('sensor',tag)-1) Regiao, count(*) Qtd
		from evento
		group by tag
		
	 ) T
group by t.Regiao
union
select tag Regiao, count(*) Qtd
from evento
group by tag
order by 1

  select  substring('brasil.sudeste.sensor01',CHARINDEX('.','brasil.sudeste.sensor01')+1, CHARINDEX('sensor','brasil.sudeste.sensor01')-9)

  select  substring('brasil.sul.sensor01',0, CHARINDEX('sensor','brasil.sul.sensor01')-1)


  select * from evento

insert into Evento values (1539112021333,	'brasil.sul.sensor02', '1')	
insert into Evento values (1539112021301,	'brasil.sudeste.sensor01',	'teste')
insert into Evento values (1539112020330,	'brasil.sul.sensor01',	'1')
insert into Evento values (1539112021331,	'brasil.sudeste.sensor02',	'<string>')
insert into Evento values (1539112021332,	'brasil.sul.sensor01',	'<string>')
insert into Evento values (1539112021301,	'brasil.sudeste.sensor01',	'<string>')
insert into Evento values (1539112021333,	'brasil.sul.sensor02',	'<stdfdfdfdring>')
*/