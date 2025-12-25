# 🎲 C# Sayı Tahmin Oyunu (SQL Tabanlı)

Bu proje, **Görsel Programlama II** dersi kapsamında geliştirilmiş, veritabanı bağlantılı, çok katmanlı bir **Sayı Tahmin (Mastermind)** oyunudur.

Kullanıcıların kayıt olup giriş yapabildiği, skorlarının veritabanında tutulduğu ve en yüksek puanların listelendiği dinamik bir Windows Forms uygulamasıdır.

## 🚀 Özellikler

* **🔐 Üyelik Sistemi:**
    * Kullanıcı Kayıt (Register) ve Giriş (Login) ekranları.
    * SQL Server üzerinde güvenli veri saklama.
    * SHA-256 ile parola şifreleme (Opsiyonel güvenlik katmanı).

* **🎮 Oyun Mekaniği:**
    * **3 Farklı Zorluk Seviyesi:** 3, 4 ve 5 haneli sayı tahmin seçenekleri.
    * **Akıllı İpuçları:**
        * 🟩 **YEŞİL:** Rakam ve yeri doğru.
        * 🟦 **MAVİ:** Rakam var, yeri yanlış.
        * 🟥 **KIRMIZI:** Rakam yok.
    * **Dinamik Puanlama:** Zorluk seviyesine ve bitirme süresine göre puan hesaplama.

* **💻 Kullanıcı Arayüzü (UI):**
    * Modern **Dark Mode** (Karanlık Mod) tasarımı.
    * Neon efektli butonlar ve listeler.
    * **Sanal Klavye:** Mouse ile veri girişi.
    * **Fiziksel Klavye Desteği:** Sadece rakam girişine izin veren özel filtreleme.

* **🏆 Skor Tablosu (Leaderboard):**
    * Veritabanından çekilen "Top 5" listesi.
    * Anlık güncellenen sıralama sistemi.

## 🛠️ Kullanılan Teknolojiler

* **Dil:** C#
* **Platform:** .NET Framework (Windows Forms)
* **Veritabanı:** Microsoft SQL Server (ADO.NET)
* **IDE:** Visual Studio 2022

## 📸 Ekran Görüntüleri

<img width="1364" height="680" alt="Ekran görüntüsü 2025-12-25 220327" src="https://github.com/user-attachments/assets/492c54ea-1777-42f6-8e79-f14bbcea12e4" /> <img width="267" height="303" alt="Ekran görüntüsü 2025-12-25 222657" src="https://github.com/user-attachments/assets/3e786ad4-371a-4b2f-b5a2-5d63912266d3" />


## ⚙️ Kurulum ve Çalıştırma

Bu projeyi bilgisayarınızda çalıştırmak için aşağıdaki adımları izleyin:

1.  Projeyi indirin veya klonlayın.
2.  **Veritabanı Kurulumu:**
    * SQL Server Management Studio'yu açın.
    * `Database_Script.sql` (veya proje içindeki SQL kodları) dosyasını çalıştırarak `OyunProjesi` veritabanını ve tablolarını oluşturun.
3.  **Bağlantı Ayarı:**
    * `VeriYoneticisi.cs` dosyasını açın.
    * `connectionString` satırını kendi SQL sunucu adınıza göre güncelleyin:
    ```csharp
    Data Source=.\SQLEXPRESS;Initial Catalog=OyunProjesi;Integrated Security=True
    ```
4.  Projeyi **Visual Studio** ile açın ve `Start` tuşuna basın.
5.  **Admin Girişi (Test İçin):**
    * Kullanıcı Adı: `admin`
    * Parola: `1234`

## 👨‍💻 Geliştirici

**Nisa Nur Çakır**
* Bilgisayar Programcılığı 2. Sınıf Öğrencisi
* [GitHub Profilin](https://github.com/KULLANICI_ADIN)
* [LinkedIn Profilin](Link Varsa)

---
