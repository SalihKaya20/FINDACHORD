using FINDACHORD.Entity;
using Microsoft.EntityFrameworkCore;

namespace FINDACHORD.Data
{
    public static class SeedData
    {
        public static void TestDatas(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.CreateScope().ServiceProvider.GetService<DataContext>();

            if(context != null)
            {
                if(context.Database.GetPendingMigrations().Any())
                {
                    context.Database.Migrate();
                }



                //chords

                if (!context.Chords.Any())
                {
                    var chords = new List<Entity.Chord>
                    {
                        new Entity.Chord {ChordId=1, ChordName = "Em" },
                        new Entity.Chord {ChordId=2, ChordName = "B" },
                        new Entity.Chord {ChordId=3, ChordName = "Am" },
                        new Entity.Chord {ChordId=4, ChordName = "G" },
                        new Entity.Chord {ChordId=5, ChordName = "F#m" },
                        new Entity.Chord {ChordId=6, ChordName = "Em" },
                        new Entity.Chord {ChordId=7, ChordName = "D" },
                        new Entity.Chord {ChordId=8, ChordName = "E" },
                        new Entity.Chord {ChordId=9, ChordName = "Bm" }, 
                        new Entity.Chord {ChordId=10, ChordName = "C#m" },       
                        new Entity.Chord {ChordId=11, ChordName = "A" },
                        new Entity.Chord {ChordId=12, ChordName = "Dm" },
                        new Entity.Chord {ChordId=13, ChordName = "E7" },
                        new Entity.Chord {ChordId=14, ChordName = "C" },
                        new Entity.Chord {ChordId=15, ChordName = "G7" },
                        new Entity.Chord {ChordId=16, ChordName = "Am7" },
                        new Entity.Chord {ChordId=17, ChordName = "F" },
                        new Entity.Chord {ChordId=18, ChordName = "Cm" },
                        new Entity.Chord {ChordId=19, ChordName = "Gm" },
                        new Entity.Chord {ChordId=20, ChordName = "D7" },
                        new Entity.Chord {ChordId=21, ChordName = "Ab" },
                        new Entity.Chord {ChordId=22, ChordName = "Db" },
                        new Entity.Chord {ChordId=23, ChordName = "Gb" },
                        new Entity.Chord {ChordId=24, ChordName = "Cb" },
                        new Entity.Chord {ChordId=25, ChordName = "Eb" },
                        new Entity.Chord {ChordId=26, ChordName = "Abm" },
                        new Entity.Chord {ChordId=27, ChordName = "Dbm" },
                        new Entity.Chord {ChordId=28, ChordName = "Gbm" },
                        new Entity.Chord {ChordId=29, ChordName = "Cbm" },
                        new Entity.Chord {ChordId=30, ChordName = "Ebm" },
                        new Entity.Chord {ChordId=31, ChordName = "Ab7" },
                        new Entity.Chord {ChordId=32, ChordName = "Db7" },
                        new Entity.Chord {ChordId=33, ChordName = "Gb7" },
                        new Entity.Chord {ChordId=34, ChordName = "Cb7" },
                        new Entity.Chord {ChordId=35, ChordName = "Eb7" },
                        new Entity.Chord {ChordId=36, ChordName = "Abm7" },
                        new Entity.Chord {ChordId=37, ChordName = "Dbm7" },
                        new Entity.Chord {ChordId=38, ChordName = "Gbm7" },
                        new Entity.Chord {ChordId=39, ChordName = "Cbm7" },
                        new Entity.Chord {ChordId=40, ChordName = "Ebm7" },
                        new Entity.Chord {ChordId=41, ChordName = "A7" },
                        new Entity.Chord {ChordId=42, ChordName = "B7" },
                        new Entity.Chord {ChordId=43, ChordName = "C7" },
                        new Entity.Chord {ChordId=44, ChordName = "D7" },
                        new Entity.Chord {ChordId=45, ChordName = "E7" },
                        new Entity.Chord {ChordId=46, ChordName = "F7" },
                        new Entity.Chord {ChordId=47, ChordName = "G7" },
                        new Entity.Chord {ChordId=48, ChordName = "Am7" },
                        new Entity.Chord {ChordId=49, ChordName = "Bm7" },
                        new Entity.Chord {ChordId=50, ChordName = "Cm7" },
                        new Entity.Chord {ChordId=51, ChordName = "D#m" },
                        new Entity.Chord {ChordId=52, ChordName = "F#7" },
                        new Entity.Chord {ChordId=53, ChordName = "G#m" },
                        new Entity.Chord {ChordId=54, ChordName = "A#m" },
                        new Entity.Chord {ChordId=55, ChordName = "C#7" },
                        new Entity.Chord {ChordId=56, ChordName = "D#7" },
                        new Entity.Chord {ChordId=57, ChordName = "F#m7" },
                        new Entity.Chord {ChordId=58, ChordName = "G#7" },
                        new Entity.Chord {ChordId=59, ChordName = "A#7" },
                        new Entity.Chord {ChordId=60, ChordName = "C#m7" },
                        new Entity.Chord {ChordId=61, ChordName = "D#m7" },
                        new Entity.Chord {ChordId=62, ChordName = "F#m" },
                        new Entity.Chord {ChordId=63, ChordName = "G#m7" },
                        new Entity.Chord {ChordId=64, ChordName = "A#m7" },
                        new Entity.Chord {ChordId=65, ChordName = "C#m" },
                        new Entity.Chord {ChordId=66, ChordName = "D#m7" },
                        new Entity.Chord {ChordId=67, ChordName = "F#m7" },
                        new Entity.Chord {ChordId=68, ChordName = "G#m" },
                        new Entity.Chord {ChordId=69, ChordName = "A#m7" },
                        new Entity.Chord {ChordId=70, ChordName = "C#m7" },
                        new Entity.Chord {ChordId=71, ChordName = "D#m7" },
                        new Entity.Chord {ChordId=72, ChordName = "F#m" },
                        new Entity.Chord {ChordId=73, ChordName = "G#m7" },
                        new Entity.Chord {ChordId=74, ChordName = "A#m" },
                        new Entity.Chord {ChordId=75, ChordName = "C#m7" },
                        new Entity.Chord {ChordId=76, ChordName = "D#m7" },
                        new Entity.Chord {ChordId=77, ChordName = "F#m7" },
                        new Entity.Chord {ChordId=78, ChordName = "G#m" },
                        new Entity.Chord {ChordId=79, ChordName = "A#m7" },
                        new Entity.Chord {ChordId=80, ChordName = "C#m7" },
                        new Entity.Chord {ChordId=81, ChordName = "D#m7" },
                        new Entity.Chord {ChordId=82, ChordName = "F#m" },
                        new Entity.Chord {ChordId=83, ChordName = "G#m7" },
                        new Entity.Chord {ChordId=84, ChordName = "A#m" },
                        new Entity.Chord {ChordId=85, ChordName = "C#m7" },
                        new Entity.Chord {ChordId=86, ChordName = "D#m7" },
                        new Entity.Chord {ChordId=87, ChordName = "F#m7" },
                        new Entity.Chord {ChordId=88, ChordName = "G#m" },
                        new Entity.Chord {ChordId=89, ChordName = "A#m7" },
                        new Entity.Chord {ChordId=90, ChordName = "C#m7" },
                        new Entity.Chord {ChordId=91, ChordName = "D#m7" },
                        new Entity.Chord {ChordId=92, ChordName = "F#m" },
                        new Entity.Chord {ChordId=93, ChordName = "G#m7" },
                        new Entity.Chord {ChordId=94, ChordName = "A#m" },
                        new Entity.Chord {ChordId=95, ChordName = "C#m7" },
                        new Entity.Chord {ChordId=96, ChordName = "D#m7" },
                        new Entity.Chord {ChordId=97, ChordName = "F#m7" },
                        new Entity.Chord {ChordId=98, ChordName = "G#m" },
                        new Entity.Chord {ChordId=99, ChordName = "A#m7" },
                        new Entity.Chord {ChordId=100, ChordName = "C#m7" },
                        new Entity.Chord {ChordId=101, ChordName = "Ebmaj7" },
                        new Entity.Chord {ChordId=102, ChordName = "Abmaj7" },
                        new Entity.Chord {ChordId=103, ChordName = "Dbmaj7" },
                        new Entity.Chord {ChordId=104, ChordName = "Gbmaj7" },
                        new Entity.Chord {ChordId=105, ChordName = "Cbmaj7" },
                        new Entity.Chord {ChordId=106, ChordName = "Fbmaj7" },
                        new Entity.Chord {ChordId=107, ChordName = "Bbmaj7" },
                        new Entity.Chord {ChordId=108, ChordName = "Ebmaj7" },
                        new Entity.Chord {ChordId=109, ChordName = "Abmaj7" },
                        new Entity.Chord {ChordId=110, ChordName = "Dbmaj7" },
                        new Entity.Chord {ChordId=111, ChordName = "Gbmaj7" },
                        new Entity.Chord {ChordId=112, ChordName = "Cbmaj7" },
                        new Entity.Chord {ChordId=113, ChordName = "Fbmaj7" },
                        new Entity.Chord {ChordId=114, ChordName = "Bbmaj7" },
                        new Entity.Chord {ChordId=115, ChordName = "Ebmaj7" },
                        new Entity.Chord {ChordId=116, ChordName = "Abmaj7" },
                        new Entity.Chord {ChordId=117, ChordName = "Dbmaj7" },
                        new Entity.Chord {ChordId=118, ChordName = "Gbmaj7" },
                        new Entity.Chord {ChordId=119, ChordName = "Cbmaj7" },
                        new Entity.Chord {ChordId=120, ChordName = "Fbmaj7" },
                        new Entity.Chord {ChordId=121, ChordName = "Bbmaj7" },
                        new Entity.Chord {ChordId=122, ChordName = "Ebmaj7" },
                        new Entity.Chord {ChordId=123, ChordName = "Abmaj7" },
                        new Entity.Chord {ChordId=124, ChordName = "Dbmaj7" },
                        new Entity.Chord {ChordId=125, ChordName = "Gbmaj7" },
                        new Entity.Chord {ChordId=126, ChordName = "Cbmaj7" },
                        new Entity.Chord {ChordId=127, ChordName = "Fbmaj7" },
                        new Entity.Chord {ChordId=128, ChordName = "Bbmaj7" },
                        new Entity.Chord {ChordId=129, ChordName = "Ebmaj7" },
                        new Entity.Chord {ChordId=130, ChordName = "Abmaj7" },
                        new Entity.Chord {ChordId=131, ChordName = "Dbmaj7" },
                        new Entity.Chord {ChordId=132, ChordName = "Gbmaj7" },
                        new Entity.Chord {ChordId=133, ChordName = "Cbmaj7" },
                        new Entity.Chord {ChordId=134, ChordName = "Fbmaj7" },
                        new Entity.Chord {ChordId=135, ChordName = "Bbmaj7" },
                        new Entity.Chord {ChordId=136, ChordName = "Ebmaj7" },
                        new Entity.Chord {ChordId=137, ChordName = "Abmaj7" },
                        new Entity.Chord {ChordId=138, ChordName = "Dbmaj7" },
                        new Entity.Chord {ChordId=139, ChordName = "Gbmaj7" },
                        new Entity.Chord {ChordId=140, ChordName = "Cbmaj7" },
                        new Entity.Chord {ChordId=141, ChordName = "Fbmaj7" },
                        new Entity.Chord {ChordId=142, ChordName = "Bbmaj7" },
                        new Entity.Chord {ChordId=143, ChordName = "Ebmaj7" },
                        new Entity.Chord {ChordId=144, ChordName = "Abmaj7" },
                        new Entity.Chord {ChordId=145, ChordName = "Dbmaj7" },
                        new Entity.Chord {ChordId=146, ChordName = "Gbmaj7" },
                        new Entity.Chord {ChordId=147, ChordName = "Cbmaj7" },
                        new Entity.Chord {ChordId=148, ChordName = "Fbmaj7" },
                        new Entity.Chord {ChordId=149, ChordName = "Bbmaj7" },
                        new Entity.Chord {ChordId=150, ChordName = "Ebmaj7" },
                        new Entity.Chord {ChordId=151, ChordName = "Abmaj7" },
                        new Entity.Chord {ChordId=152, ChordName = "Dbmaj7" },
                        new Entity.Chord {ChordId=153, ChordName = "Gbmaj7" },
                        new Entity.Chord {ChordId=154, ChordName = "Cbmaj7" },
                        new Entity.Chord {ChordId=155, ChordName = "Fbmaj7" },
                        new Entity.Chord {ChordId=156, ChordName = "Bbmaj7" },
                        new Entity.Chord {ChordId=157, ChordName = "Ebmaj7" },
                        new Entity.Chord {ChordId=158, ChordName = "Abmaj7" },
                        new Entity.Chord {ChordId=159, ChordName = "Dbmaj7" },
                        new Entity.Chord {ChordId=160, ChordName = "Gbmaj7" },
                        new Entity.Chord {ChordId=161, ChordName = "Cbmaj7" },
                        new Entity.Chord {ChordId=162, ChordName = "Fbmaj7" },
                        new Entity.Chord {ChordId=163, ChordName = "Bbmaj7" },
                        new Entity.Chord {ChordId=164, ChordName = "Ebmaj7" },
                        new Entity.Chord {ChordId=165, ChordName = "Abmaj7" },
                        new Entity.Chord {ChordId=166, ChordName = "Dbmaj7" },
                        new Entity.Chord {ChordId=167, ChordName = "Gbmaj7" },
                        new Entity.Chord {ChordId=168, ChordName = "Cbmaj7" },
                        new Entity.Chord {ChordId=169, ChordName = "Fbmaj7" },
                        new Entity.Chord {ChordId=170, ChordName = "Bbmaj7" },
                        new Entity.Chord {ChordId=171, ChordName = "Ebmaj7" },
                        new Entity.Chord {ChordId=172, ChordName = "Abmaj7" },
                        new Entity.Chord {ChordId=173, ChordName = "Dbmaj7" },
                        new Entity.Chord {ChordId=174, ChordName = "Gbmaj7" },
                        new Entity.Chord {ChordId=175, ChordName = "Cbmaj7" },
                        new Entity.Chord {ChordId=176, ChordName = "Fbmaj7" },
                        new Entity.Chord {ChordId=177, ChordName = "Bbmaj7" },
                        new Entity.Chord {ChordId=178, ChordName = "Ebmaj7" },
                        new Entity.Chord {ChordId=179, ChordName = "Abmaj7" },
                        new Entity.Chord {ChordId=180, ChordName = "Dbmaj7" },
                        new Entity.Chord {ChordId=181, ChordName = "Gbmaj7" },
                        new Entity.Chord {ChordId=182, ChordName = "Cbmaj7" },
                        new Entity.Chord {ChordId=183, ChordName = "Fbmaj7" },
                        new Entity.Chord {ChordId=184, ChordName = "Bbmaj7" },
                        new Entity.Chord {ChordId=185, ChordName = "Ebmaj7" },
                        new Entity.Chord {ChordId=186, ChordName = "Abmaj7" },
                        new Entity.Chord {ChordId=187, ChordName = "Dbmaj7" },
                        new Entity.Chord {ChordId=188, ChordName = "Gbmaj7" },
                        new Entity.Chord {ChordId=189, ChordName = "Cbmaj7" },
                        new Entity.Chord {ChordId=190, ChordName = "Fbmaj7" },
                        new Entity.Chord {ChordId=191, ChordName = "Bbmaj7" },
                        new Entity.Chord {ChordId=192, ChordName = "Ebmaj7" },
                        new Entity.Chord {ChordId=193, ChordName = "Abmaj7" },
                        new Entity.Chord {ChordId=194, ChordName = "Dbmaj7" },
                        new Entity.Chord {ChordId=195, ChordName = "Gbmaj7" },
                        new Entity.Chord {ChordId=196, ChordName = "Cbmaj7" },
                        new Entity.Chord {ChordId=197, ChordName = "Fbmaj7" },
                        new Entity.Chord {ChordId=198, ChordName = "Bbmaj7" },
                        new Entity.Chord {ChordId=199, ChordName = "Ebmaj7" },
                        new Entity.Chord {ChordId=200, ChordName = "Abmaj7" }
                    
                    };

                    context.Chords.AddRange(chords);
                    context.SaveChanges();
                }








                //artists
                if (!context.Artists.Any())
                {
                    var artists = new List<Entity.Artist>
                    {
                        new Entity.Artist { ArtistId = 1, ArtistName = "Şebnem Ferah" },
                        new Entity.Artist { ArtistId = 2, ArtistName = "Sertab Erener" },
                        new Entity.Artist { ArtistId = 3, ArtistName = "Example Artist" },
                    };

                    context.Artists.AddRange(artists);
                    context.SaveChanges();
                }












                //songs

                if(!context.Songs.Any())
                {
                    context.Songs.AddRange(


                        new Entity.Song {
                        SongId = 1,
                        SongName = "Sil Baştan",
                        ArtistId=1,
                        Chords = new List<Entity.Chord>
                        {
                            context.Chords.First(c => c.ChordName =="Em"),
                            context.Chords.First(c => c.ChordName =="B"),
                            context.Chords.First(c => c.ChordName =="Am"),
                            context.Chords.First(c => c.ChordName =="G"),
                            context.Chords.First(c => c.ChordName =="B")
                        },                                 
                        LyricsWithChords = 
                        @"
                        [Em:0]Gücün var mı sevgilim[B:17],
                        [Am:10]Derin sularda inci [G:24]tanesi [Em:32]aramaya
                        [Em:0]Cesaretin [B:16]kaldıysa
                        [Am:8]Hala benle aşktan [G:16]konuşmaya[Em:23]  

                        [Em:0]Söyle canım [B:16]sevgilim
                        [Am:7]Hayat bize oyun [G:19]oynuyor olabilir [Em:31]mi
                        [Em:0]Yorgun gibi bir [B:19]halin var
                        [Am:6]Duyguların [G:16]karışık [Em:23]olabilir mi    

                        [Em:0]Sil baştan başlamak [B:28]gerek bazen 
                        [Em:0]Hayatı [B:14]sıfırlamak
                        [Am:0]Sil baştan sevmek [Em:20]gerek bazen   
                        [B:0]Her şeyi [Em:12]unutmak                 
 
                        [Em:0]Sanki bugün son günmüş [B:22]gibi
                        [Am:4]Dolu dolu yaşamak [G:15]istiyorum [Em:25]ben
                        [Em:0]Her ne çıkarsa [B:18]yoluma
                        [Am:8]Selam verip yürümek [G:18]istiyorum [Em:27]ben"
                        
                        },



                        new Entity.Song{
                        SongId=2,
                        SongName="Olsun",
                        ArtistId=2,
                        Chords = new List<Entity.Chord>
                        {
                            context.Chords.First(c => c.ChordName =="F#m"),
                            context.Chords.First(c => c.ChordName =="E"),
                            context.Chords.First(c => c.ChordName =="D"),
                            context.Chords.First(c => c.ChordName =="Bm"),
                            context.Chords.First(c => c.ChordName =="C#m")
                        
                        },                       
                        LyricsWithChords = 
                        @"
                        İntro : [F#m:0]    [E:5]    [F#m:10]    [E:15]    [F#m:20]    [E:25]    [D:30]

                        [F#m:0]Artık ne masumuz
                        [E:0]Ne yalandan yok[D:17]sun, bırak olsun
                        [F#m:0]Resimleri sen al
                        [E:0]Mevsimler zaten be[D:20]nim, hadi olsun
                        [F#m:0]Bölüşürüz bu şiirler
                        [E:0]Arkadaşlar şehir[D:19]ler, olan olsun
                        [F#m:0]Artık ne özgürüz
                        [E:0]Ne de özgür ömrü[D:18]müz, hadi olsun

                        [Bm:0]Ben giderim İs[C#m:13]tanbul se[D:23]nin ols[E:30]un x2
                        

                        [F#m:0]Alırım başım[E:11]ı başım bir deli neh[D:31]ir
                        [E:21]Silerim yaşımı siler ismimi şeh[F#m:30]ir
                        [E:15]Kestirir saçımı kendimi avutur[D:30]um
                        [Bm:16]Bir gülü kurutur kurur[C#m:22]sa unutur[F#m:31]um

                        [F#m:0]Bir mektup yaza[E:17]rım yokluğundan dağıl[D:34]ır
                        [E:24]Bir kedi alırım sen de anneni çağı[F#m:32]r
                        [E:14]Ellerin aklımda sevdan kalbimde kal[D:34]ır
                        [Bm:14]Hep hüsran hep kahır söy[C#m:21]le artık[F#m:32] olsun"
                                        
                        },

                        new Entity.Song{
                        SongId=3,
                        SongName="Yalnızım",
                        ArtistId=3,
                        Chords = new List<Entity.Chord>
                        {
                            context.Chords.First(c => c.ChordName =="Am"),
                            context.Chords.First(c => c.ChordName =="F"),
                            context.Chords.First(c => c.ChordName =="G"),
                            context.Chords.First(c => c.ChordName =="C")
                        
                        },                       
                        LyricsWithChords = 
                        @"
                        [Am:0]Yalnızım, yalnızım, [F:5]yalnızım, yalnızım
                        [G:10]Yalnızım, yalnızım, [C:15]yalnızım, yalnızım

                        [Am:0]Gecelerim, gecelerim, [F:5]gecelerim, gecelerim
                        [G:10]Gecelerim, gecelerim, [C:15]gecelerim, gecelerim

                        [Am:0]Uykusuzum, uykusuzum, [F:5]uykusuzum, uykusuzum
                        [G:10]Uykusuzum, uykusuzum, [C:15]uykusuzum, uykusuzum

                        [Am:0]Yalnızım, yalnızım, [F:5]yalnızım, yalnızım
                        [G:10]Yalnızım, yalnızım, [C:15]yalnızım, yalnızım
                        "
                                        
                        }


                    );

                    context.SaveChanges();
                }
                
            }

        }

        
    }
}
