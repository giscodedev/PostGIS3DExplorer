drop table if exists public.ahn_sample;
create table public.ahn_sample
(
  geom geometry(PointZ,28992),
  classificatie smallint,
  gps_time date
);
copy ahn_sample from '[demodatapath]/ahn_sample.csv' CSV delimiter ';';

create index ahn_sample_gidx on public.ahn_sample using gist(geom);

drop table if exists public.pand;
create table public.pand
(
  geom geometry(Polygon,28992),
  identificatie character(16)
);
copy public.pand from '[demodatapath]/pand.csv' CSV delimiter ';';

drop table if exists public.kabel;
create table public.kabel 
(
  geom geometry(linestringz, 28992)
);

insert into public.kabel values (st_GeometryFromText('LINESTRING Z (185764.938985971 594592.399697155 0,185862.536451284 594591.343447531 0)', 28992));
