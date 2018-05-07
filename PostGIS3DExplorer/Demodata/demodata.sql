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
