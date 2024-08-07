﻿CREATE PROCEDURE musterihareketler AS
SELECT HAREKETID,URUNAD,TBL_MUSTERIHAREKETLER.ADET,
(TBL_PERSONELLER.AD + ' ' + TBL_PERSONELLER.SOYAD) AS 'AD-SOYAD',
(TBL_MUSTERILER.AD + ' ' + TBL_MUSTERILER.SOYAD) AS 'MUSTERI',
FIYAT,TOPLAM,TBL_MUSTERIHAREKETLER.ADET,FATURAID,TARIH,NOTLAR
FROM TBL_MUSTERIHAREKETLER
INNER JOIN TBL_URUNLER
ON TBL_MUSTERIHAREKETLER.URUNID = TBL_URUNLER.ID
INNER JOIN TBL_PERSONELLER
ON TBL_MUSTERIHAREKETLER.PERSONEL = TBL_PERSONELLER.ID
INNER JOIN TBL_MUSTERILER
ON TBL_MUSTERIHAREKETLER.MUSTERI = TBL_MUSTERILER.ID