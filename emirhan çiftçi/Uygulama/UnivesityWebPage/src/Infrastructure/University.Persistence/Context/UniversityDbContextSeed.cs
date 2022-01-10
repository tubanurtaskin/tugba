using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using University.Domain.Models;

namespace University.Persistence.Context
{
    public class UniversityDbContextSeed
    {
        public async Task SeedAsync(UniversityDbContext context, ILogger<UniversityDbContext> logger)
        {

            if (!context.Sections.Any())
            {
                context.Sections.AddRange(GetDefaultSections());
                await context.SaveChangesAsync();
            }

            if (!context.Links.Any())
            {
                context.Links.AddRange(GetDefaultLinks());
                await context.SaveChangesAsync();
            }
        }

        private IEnumerable<Section> GetDefaultSections()
        {
            yield return new Section
            {
                Name = "Header",
                Content = @"<section class='flex items-center justify-center'>"+
                           "<img src='./assets/img/anasayfa.jpg' class='w-full h-full'></section>",
                Priority = 0,
            };
            yield return new Section
            {
                Name = "Section 1",
                Content = @"<section id='headline-panel' class='footer-bg-color flex flex-col h-[75]  mt-1'>"+
                                "<div class='flex flex-col justify-center text-white w-[75rem] h-[60vh] m-auto space-y-5'><div>"
                                        +"<h2 class='text-4xl italic'>KENTİMİZ VE SANAYİ ELELE</h2>"
                                        +" <h3 class='text-4xl italic'>ÜRETEN ÜNİVERSİTE</h3></div>"
                                    +"<p class='w-[70%] italic'>Sanayi ve iş dünyası ile üniversiteyi ortak akıl, ortak hedef ve ortak başarı ilkeleri doğrultusunda ortak projelerle biraraya getirerek üniversitenin ve sanayinin gelişmesine katkıda bulunmaktır.</p></div></section>",
                Priority = 1,

            };
            yield return new Section
            {
                Name = "Section 2",
                Content = @"<section class='flex justify-center items-center'>"
    + "<div class='flex flex-grow-[1]'>"
      + "<img src='./assets/img/headline-back-01.png' class='w-full' /></div>"
    + "<div class='flex flex-grow-[1]  flex-col justify-center space-y-10'>"
      + "<h2 class='flex items-start justify-start text-5xl ml-15 text-info'>2006'DAN BUGUNE</h2>"
      + "<div class='flex flex-col space-y-20'>"
        + "<div class='flex flex-row justify-around'>"
           + "<div class='flex flex-col justify-center items-center space-y-4 w-32'>"
                + "<div class='text-6xl text-info border-2 border-solid border-info rounded-full w-[130px] h-[130px] flex justify-center items-center'>14</div>"
                + "<span class='text-info text-xl text-center'>FAKÜLTE</span></div>"
              + "<div class='flex flex-col justify-center items-center space-y-4 w-32'>"
                  + "<div class='text-6xl text-info border-2 border-solid border-info rounded-full w-[130px] h-[130px] flex justify-center items-center'>4</div>"
                  + "<span class='text-info text-xl text-center'>ENSTİTÜ</span></div></div>"
          + "<div class='flex flex-row justify-around'>"
            + "<div class='flex flex-col justify-center items-center space-y-4 w-32'>"
                + "<div class='text-6xl text-info border-2 border-solid border-info rounded-full w-[130px] h-[130px] flex justify-center items-center'>2</div>"
                + "<span class='text-info text-xl text-center'>YÜKSEKOKUL</span></div>"
              + "<div class='flex flex-col justify-center items-center space-y-4 w-32'>"
                  + "<div class='text-6xl text-info border-2 border-solid border-info rounded-full w-[130px] h-[130px] flex justify-center items-center'>10</div>"
                  + "<span class='text-info text-xl text-center'>MESLEK YÜKSEKOKULU</span></div></div><div></div></div></div></section>",
                Priority = 2,
            };
            yield return new Section
            {
                Name = "Section 3",
                Content = @"<section class='flex justify-center items-center footer-bg-color'>
    <div class='flex flex-grow-[1]'>
      <img src='./assets/img/headline-back-02.png' class='w-full' />
    </div>

    <div class='flex flex-grow-[1]  flex-col justify-center space-y-10 '>
      <h2 class='flex items-start justify-start text-5xl ml-15 text-white'>2006'DAN BUGUNE</h2>
      <div class='flex flex-col space-y-20'>
        <div class='flex flex-row justify-around'>
       
            <div class='flex flex-col justify-center items-center space-y-4 w-32'>
                <div class='text-6xl text-white border-2 border-solid border-white rounded-full w-[130px] h-[130px] flex justify-center items-center'>84</div>
                <span class='text-white text-xl text-center'>LİSANS PROGRAMI</span>
              </div>

              <div class='flex flex-col justify-center items-center space-y-4 w-32'>
                  <div class='text-6xl text-white border-2 border-solid border-white rounded-full w-[130px] h-[130px] flex justify-center items-center'>94</div>
                  <span class='text-white text-xl text-center'>LİSANSÜSTÜ PROGRAMI</span>
                </div>
          </div>

          <div class='flex flex-row justify-around'>
       
            <div class='flex flex-col justify-center items-center space-y-4 w-32'>
                <div class='text-6xl text-white border-2 border-solid border-white rounded-full w-[130px] h-[130px] flex justify-center items-center'>31</div>
                <span class='text-white text-xl text-center'>UYGULAM ARAŞTIRMA MERKEZİ</span>
              </div>

              <div class='flex flex-col justify-center items-center space-y-4 w-32'>
                  <div class='text-6xl text-white border-2 border-solid border-white rounded-full w-[130px] h-[130px] flex justify-center items-center'>12</div>
                  <span class='text-white text-xl text-center'>KOORDİNATÖRLÜK</span>
                </div>

          </div>

        <div>

        </div>
      </div>
    </div>

</section>",
                Priority = 3,

            };
            yield return new Section
            {
                Name = "Footer Top",
                Content = @"<section class='flex justify-center items-center'>
    <div class='flex flex-grow-[1]'>
      <img src='./assets/img/headline-back-03.png' class='w-full' />
    </div>

    <div class='flex flex-grow-[1]  flex-col justify-center space-y-10'>
      <h2 class='flex items-start justify-start text-5xl ml-15 text-info'>2006'DAN BUGUNE</h2>
      <div class='flex flex-col space-y-20'>
        <div class='flex flex-row justify-around'>
       
            <div class='flex flex-col justify-center items-center space-y-4 w-32'>
                <div class='text-6xl text-info border-2 border-solid border-info rounded-full w-[130px] h-[130px] flex justify-center items-center'>77</div>
                <span class='text-info text-xl text-center'>TUBİTAK PROJESİ</span>
              </div>

              <div class='flex flex-col justify-center items-center space-y-4 w-32'>
                  <div class='text-5xl text-info border-2 border-solid border-info rounded-full w-[130px] h-[130px] flex justify-center items-center'>1092</div>
                  <span class='text-info text-xl text-center'>BAP PROJESİ</span>
                </div>
          </div>

          <div class='flex flex-row justify-around'>
       
            <div class='flex flex-col justify-center items-center space-y-4 w-32'>
                <div class='text-6xl text-info border-2 border-solid border-info rounded-full w-[130px] h-[130px] flex justify-center items-center'>-</div>
                <span class='text-info text-xl text-center'>SPONSORLU PROJE</span>
              </div>

              <div class='flex flex-col justify-center items-center space-y-4 w-32'>
                  <div class='text-6xl text-info border-2 border-solid border-info rounded-full w-[130px] h-[130px] flex justify-center items-center'>1</div>
                  <span class='text-info text-xl text-center'>PATENT</span>
                </div>

          </div>

        <div>

        </div>
      </div>
    </div>

</section>",
                Priority = 4,
            };
            yield return new Section
            {
                Name = "Footer",
                Content = @"<section class='flex items-center justify-end h-[50vh] w-[50%] mb-5 '>
    <div class='pt-8 w-[60%] flex flex-col space-y-4'>
      <h3 class='text-color text-4xl' >KARINCALAR GİBİ OL...</h3>
      <h2 class='text-color text-4xl'>ÇALIŞAN, ÜRETEN, GELİŞEN</h2>
      <h3 class='text-color text-4xl'>DÜZCE ÜNİVERSİTEM</h3>
      <div class='hr'></div>
      <div class='flex space-x-10 justify-end'>
          <div class='text-info text-xl flex-grow-1 flex flex-col space-y-3'>
              <a href='#'>AÇIK KAMPÜS<span>'e Katıl</span> 
                <br>
                  NEDİR?
              </a>
              <a href='#'>GETAT<span>'ı Gör</span>
                  <br>
                  NEDİR?
              </a>
          </div>
          <div class='text-info text-xl flex-grow-1 flex flex-col space-y-3'>
              <a href='#'>DÜKKAN<span>'a Git</span>
                  <br>
                  NEDİR?
              </a>
              <a href='#'> RADYO DÜET<span> Dinle</span></a>
          </div>
      </div>
  </div>

  </section>",
                Priority = 5,
            };
        }


        private IEnumerable<Link> GetDefaultLinks()
        {
            yield return new Link
            {
                Name = "Universitemiz",
                IsNode = true,
                Href = "#",
                SubLinks = new List<Link>()
                {
                    new Link
                    {
                        Name = "Düzce",
                        Href = "#"
                    },
                    new Link
                    {
                        Name = "Kuruluş",
                        Href = "#"
                    },
                    new Link
                    {
                        Name = "Yönetim",
                        Href = "#",
                        SubLinks= new List<Link>()
                        {
                            new Link
                            {
                                Name = "Rektör",
                                Href = "#",
                            },
                            new Link
                            {
                                Name = "Rektor Yardımcıları",
                                Href = "#",
                            },
                            new Link
                            {
                                Name = "Senato",
                                Href = "#",
                            },
                            new Link
                            {
                                Name = "Yönetim Kurulu",
                                Href = "#",
                            },
                            new Link
                            {
                                Name = "Genel Sekreter",
                                Href = "#",
                            },
                            new Link
                            {
                                Name = "Teşkilat Şeması",
                                Href = "#",
                            },
                            new Link
                            {
                                Name = "Senato ve Yönetim Kurulu Kararları",
                                Href = "#",
                            },
                            new Link
                            {
                                Name = "Rektörlerimiz",
                                Href = "#",
                            },
                        }

                    },
                    new Link
                    {
                        Name = "Saygılarla DÜ",
                        Href = "#",
                        SubLinks = new List<Link>
                        {
                            new Link
                            {
                                Name = "Öğrenci Sayıları",
                                Href = "#",
                            },
                            new Link
                            {
                                Name = "Personel Sayıları",
                                Href = "#",
                            },
                            new Link
                            {
                                Name = "Bölüm ve Program Sayıları",
                                Href = "#",
                            },
                            new Link
                            {
                                Name = "Proje Sayıları",
                                Href = "#",
                            },
                            new Link
                            {
                                Name = "Fikri Mülkiyet",
                                Href = "#",
                            },
                            new Link
                            {
                                Name = "Derslik",
                                Href = "#",
                            },
                            new Link
                            {
                                Name = "Üniversite İzleme ve Değerlendirme Raporu",
                                Href = "#",
                            },
                            new Link
                            {
                                Name = "Bütçe",
                                Href = "#",
                            },
                        }
                    },
                    new Link
                    {
                        Name = "Sıralamalar",
                        Href = "#",
                        SubLinks= new List<Link>
                        {
                            new Link
                            {
                                Name = "URAP",
                                Href="#",
                            },
                            new Link
                            {
                                Name = "THE",
                                Href="#",
                            },
                            new Link
                            {
                                Name = "Girişimcilik Endeksi",
                                Href="#",
                            },
                            new Link
                            {
                                Name = "Green Metric",
                                Href="#",
                            },
                            new Link
                            {
                                Name = "InnovaLig",
                                Href="#",
                            },
                        }
                    },
                    new Link
                    {
                        Name = "İlkler",
                        Href = "#"
                    },
                    new Link
                    {
                        Name = "Kurumsal Strateji",
                        Href = "#",
                        SubLinks = new List<Link>
                        {
                            new Link
                            {
                                Name = "Stratejik Plan 2020-2024",
                                Href = "#"
                            },
                            new Link
                            {
                                Name = "Kalite Politikası",
                                Href = "#"
                            },
                            new Link
                            {
                                Name = "Sürekli İyileştirme",
                                Href = "#"
                            },
                            new Link
                            {
                                Name = "KİDR",
                                Href = "#"
                            },
                            new Link
                            {
                                Name = "Sürdürülebilirlik Raporu",
                                Href = "#"
                            },

                        }
                    },
                    new Link
                    {
                        Name = "İdari Birimler",
                        Href = "#"
                    },
                    new Link
                    {
                        Name = "Kampüs Yaşamı",
                        Href = "#",
                        SubLinks = new List<Link>
                        {
                            new Link
                            {
                                Name = "Yeme/İçme",
                                Href = "#"
                            },
                            new Link
                            {
                                Name = "Spor Merkezleri",
                                Href = "#"
                            },
                            new Link
                            {
                                Name = "Ulaşım",
                                Href = "#"
                            },
                            new Link
                            {
                                Name = "Barınma",
                                Href = "#"
                            },
                            
                        }
                        
                    },
                    new Link
                    {
                        Name = "İşbirlikleri",
                        Href = "#"
                    },
                    new Link
                    {

                        Name = "Tanıtım Filmleri/Fotoğraf Galerisi",
                        Href = "#"
                    },
                    new Link
                    {
                        Name = "Yönetmelik ve Yönergeler",
                        Href = "#"
                    },
                    new Link
                    {

                        Name = "Bilgi Güvenliği Politikamız",
                        Href = "#"
                    }

                }
            };
            yield return new Link
            {
                Name = "Akademik",
                Href = "#",
                IsNode = true,
                SubLinks = new List<Link>
                {
                    new Link
                    {
                        Name="Fakülteler",
                        Href="#",
                        SubLinks=new List<Link>
                        {
                            new Link
                            {
                                Name = "Akçakoca Bey Siyasal Bilgiler Fakültesi",
                                Href = "#",
                            },
                            new Link
                            {
                                Name = "Eğitim Fakültesi",
                                Href = "#",
                            },
                            new Link
                            {
                                Name = "İlahiyat Fakültesi",
                                Href = "#",
                            },
                            new Link
                            {
                                Name = "İşletme Fakültesi",
                                Href = "#",
                            },
                            new Link
                            {
                                Name = "Mühendislik Fakültesi",
                                Href = "#",
                            },
                            new Link
                            {
                                Name = "Orman Fakültesi",
                                Href = "#",
                            },
                            new Link
                            {
                                Name = "Sağlık Bilimleri Fakültesi",
                                Href = "#",
                            },
                            new Link
                            {
                                Name = "Sanat,Tasarım ve MimarlıkFakültesi",
                                Href = "#",
                            },
                            new Link
                            {
                                Name = "Spor Bilimleri Fakültesi",
                                Href = "#",
                            },
                            new Link
                            {
                                Name = "Tıp Fakültesi",
                                Href = "#",
                            },
                            new Link
                            {
                                Name = "Ziraat Fakültesi",
                                Href = "#",
                            },
                        }
                    },
                    new Link
                    {
                        Name="Enstitüler",
                        Href="#"
                    },
                    new Link
                    {
                        Name = "Yüksekokullar",
                        Href= "#",
                        SubLinks= new List<Link>
                        {
                            new Link
                            {
                                Name = "Akçakoca Turizm İşl. ve O.Y.O.",
                                Href = "#"
                            },
                            new Link
                            {
                                Name = "Hakime ERCİYAS Yabancı Diller Yüksekokulu",
                                Href = "#"
                            },
                        }
                    },
                    new Link
                    {
                        Name = "Meslek Yüksekokulları",
                        Href= "#",
                        SubLinks = new List<Link>
                        {
                            new Link
                            {
                                Name = "Akçakoca MYO",
                                Href = "#"
                            },
                            new Link
                            {
                                Name = "Çilimli MYO",
                                Href = "#"
                            },
                            new Link
                            {
                                Name = "Dr. Engin PAK Cumayeri MYO",
                                Href = "#"
                            },
                            new Link
                            {
                                Name = "Gölyaka MYO",
                                Href = "#"
                            },
                            new Link
                            {
                                Name = "Gümüşova MYO",
                                Href = "#"
                            },
                            new Link
                            {
                                Name = "Kaynaşlı MYO",
                                Href = "#"
                            },
                            new Link
                            {
                                Name = "Ormancılık MYO",
                                Href = "#"
                            },
                            new Link
                            {
                                Name = "Sağlık Hizmetleri MYO",
                                Href = "#"
                            },
                            new Link
                            {
                                Name = "Sosyal Bilimler MYO",
                                Href = "#"
                            },

                        }
                    },
                    new Link
                    {
                        Name = "Kurullar",
                        Href ="#"
                    },
                    new Link
                    {
                        Name = "Bölüm Başkanlıkları",
                        Href="#",
                        SubLinks=new List<Link>
                        {
                            new Link
                            {
                                Name = "Atatürk İlkeleri ve İnkılap Tarihi Bölümü",
                                Href="#",
                            },
                            new Link
                            {
                                Name = "Türk Dili",
                                Href="#",
                            },
                        }
                    },

                }
            };
            yield return new Link
            {
                Name = "Araştırma",
                Href = "#",
                IsNode = true,
                SubLinks = new List<Link>
                {
                    new Link
                    {
                        Name = "Araştırma Merkezleri",
                        Href = "#"
                    },
                    new Link
                    {
                        Name = "Laboratuvar Envanteri",
                        Href = "#"
                    },
                    new Link
                    {
                        Name = "Yayınlar Projeler",
                        Href = "#"
                    },
                    new Link
                    {
                        Name = "Hakemli Dergiler",
                        Href = "#"
                    },
                    new Link
                    {
                        Name = "Teknoloji Transfer Ofisi",
                        Href = "#"
                    },
                }
            };
            yield return new Link
            {
                Name = "İhtisaslaşma",
                Href= "#",
                IsNode = true,
                SubLinks = new List<Link> 
                {
                    new Link
                    {
                        Name = "Program Kapsamı",
                        Href = "#"
                    },
                    new Link
                    {
                        Name = "Tıbbi Bitki Yetiştiriciliği",
                        Href = "#"
                    },
                    new Link
                    {
                        Name = "Ürünler/Markalar",
                        Href = "#"
                    },
                    new Link
                    {
                        Name = "Üretim Merkezi",
                        Href = "#"
                    },
                    new Link
                    {
                        Name = "Geleneksel ve Tamamlayıcı Tıp Faaliyetleri",
                        Href = "#"
                    },
                    new Link
                    {
                        Name = "Tarımsal Atıkların Geri Kazanımı Faaliyetleri",
                        Href = "#"
                    },
                    new Link
                    {
                        Name = "Arıcılık / Arı Ürünleri",
                        Href = "#"
                    },
                    new Link
                    {
                        Name = "Bilimsel Yayınlar",
                        Href = "#"
                    },
                    new Link
                    {
                        Name = "İşbirlikleri",
                        Href = "#"
                    },
                    new Link
                    {
                        Name = "Etkinlikler",
                        Href = "#"
                    },
                }

            };
            yield return new Link
            {
                Name = "DÜYayınlar",
                Href = "#",
                IsNode = true,

            };
            yield return new Link
            {
                Name = "DÜDuyurular",
                Href = "#",
                IsNode = true,

            };
        }
    }

   
}
