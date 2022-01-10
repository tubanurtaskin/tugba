import csv   
import matplotlib.pyplot as plt
import pandas as pd

secenek = input("    Bir istatistik seçiniz :" "\n"
                   " 1- Aktivite (grafik)" "\n"
                   " 2- Aktivite dakikası (grafik)" "\n"
                   " 3- Aktivite süreci (grafik)" "\n"
                   " 4- Vücut" "\n"
                   " 5- Kalp atışı (grafik)" "\n"
                   " 6- Kalp atışı (oto)" "\n"
                   " 7- Uyku (grafik)" "\n"
                   " 8- Spor" "\n"
                   " 9- Kullanıcı" "\n"
                   " 10- Sağlık Kontrolü" "\n")


if secenek == "1":
    with open('Veriler/ACTIVITY/ACTIVITY_1637061532025.csv','r') as csv_file:
        csv_reader = csv.reader(csv_file, delimiter=',')
        line_count = 0
        for row in csv_reader:
            if line_count == 0:
                print(f'Sütun isimleri: \n {", ".join(row)}')
                line_count += 1
                print()
            else:
                print(f'\t{row[0]} {row[1]} {row[2]} {row[3]} {row[4]}')
                line_count += 1
                print()
        print(f'{line_count -1} satır işlendi')
    karar = input("Grafik ister misiniz ?  y/n " "\n")
    if karar == "y":
        df=pd.read_csv("Veriler/ACTIVITY/ACTIVITY_1637061532025.csv")
        f=plt.figure(figsize=(12,6))
        plt.scatter(df.date,df.steps,c=df.steps,cmap='brg')
        tarih="2021-11-11"
        yazi="7000 Adımın Geçildiği Gün"
        plt.annotate(yazi,xy=(tarih,7800),xytext=(tarih,7100),arrowprops=dict(arrowstyle='->',fc='r'))
        plt.title('Güne göre atılan adımlar')
        plt.colorbar(label="Sağlıksız                                                             Sağlıklı")
        plt.show()
        
elif secenek == "2":
    with open('Veriler/ACTIVITY_MINUTE/ACTIVITY_MINUTE_1637061532201.csv','r') as csv_file:
        csv_reader = csv.reader(csv_file, delimiter=',')
        line_count = 0
        for row in csv_reader:
            if line_count == 0:
                print(f'Sütun isimleri: {", ".join(row)}')
                line_count += 1
                print()
            else:
                print(f'\t{row[0]} {row[1]} {row[2]}')
                line_count += 1
                print()
        print(f'{line_count} satır işlendi')
    karar = input("Grafik ister misiniz ?  y/n " "\n")
    if karar == "y":
        df=pd.read_csv("Veriler/ACTIVITY_MINUTE/ACTIVITY_MINUTE_1637061532201.csv")
        plt.plot(df.date,df.steps,'g')
        plt.title('Zamana göre atılan adımlar')
        plt.show()
    
elif secenek == "3":
    with open('Veriler/ACTIVITY_STAGE/ACTIVITY_STAGE_1637061532044.csv','r') as csv_file:
        csv_reader = csv.reader(csv_file, delimiter=',')
        line_count = 0
        for row in csv_reader:
            if line_count == 0:
                print(f'Sütun isimleri: {", ".join(row)}')
                line_count += 1
                print()
            else:
                print(f'\t{row[0]} {row[1]} {row[2]} {row[3]} {row[4]} {row[5]}')
                line_count += 1
                print()
        print(f'{line_count} satır işlendi')
    karar = input("Grafik ister misiniz ?  y/n " "\n")
    if karar == "y":
        df=pd.read_csv("Veriler/ACTIVITY/ACTIVITY_1637061532025.csv")
        plt.plot(df.date,df.calories)
        plt.title('Yakılan kaloriler')
        plt.show()
        
elif secenek == "4":
    with open('Veriler/BODY/BODY_1637061532337.csv','r') as csv_file:
        csv_reader = csv.reader(csv_file, delimiter=',')
        line_count = 0
        for row in csv_reader:
            if line_count == 0:
                print(f'Sütun isimleri: {", ".join(row)}')
                line_count += 1
                print()
            else:
                print(f'\t{row[0]} {row[1]} {row[2]} {row[3]} {row[4]} {row[5]} {row[6]}  {row[7]} {row[8]} {row[9]}')
                line_count += 1
                print()
        print(f'{line_count} satır işlendi')
        
elif secenek == "5":
    with open('Veriler/HEARTRATE/HEARTRATE_1637061532248.csv','r') as csv_file:
        csv_reader = csv.reader(csv_file, delimiter=',')
        line_count = 0
        for row in csv_reader:
            if line_count == 0:
                print(f'Sütun isimleri: {", ".join(row)}')
                line_count += 1
                print()
            else:
                print(f'\t{row[0]} {row[1]}')
                line_count += 1
                print()
        print(f'{line_count} satır işlendi')
    karar = input("Grafik ister misiniz ?  y/n " "\n")
    if karar == "y":
        df=pd.read_csv("Veriler/HEARTRATE/HEARTRATE_1637061532248.csv")
        plt.scatter(df.time,df.heartRate,c=df.heartRate,cmap='gist_rainbow')
        plt.title('Kalp Atışı')
        plt.colorbar(label="Sağlıksız         Sağlıklı               Sağlıksız")
        plt.show()
        
elif secenek == "6":
    with open('Veriler/HEARTRATE_AUTO/HEARTRATE_AUTO_1637061532325.csv','r') as csv_file:
        csv_reader = csv.reader(csv_file, delimiter=',')
        line_count = 0
        for row in csv_reader:
            if line_count == 0:
                print(f'Sütun isimleri: {", ".join(row)}')
                line_count += 1
                print()
            else:
                print(f'\t{row[0]} {row[1]} {row[2]} ')
                line_count += 1
                print()
        print(f'{line_count} satır işlendi')
        
elif secenek == "7":
    with open('Veriler/SLEEP/SLEEP_1637061532231.csv','r') as csv_file:
        csv_reader = csv.reader(csv_file, delimiter=',')
        line_count = 0
        for row in csv_reader:
            if line_count == 0:
                print(f'Sütun isimleri: {", ".join(row)}')
                line_count += 1
                print()
            else:
                print(f'\t{row[0]} {row[1]} {row[2]} {row[3]} {row[4]} {row[5]}')
                line_count += 1
                print()
        print(f'{line_count} satır işlendi')
    karar = input("Grafik ister misiniz ?  y/n " "\n")
    if karar == "y":
        df=pd.read_csv("Veriler/SLEEP/SLEEP_1637061532231.csv")
        plt.figure(1)
        grafik1 = plt.subplot(121)
        plt.scatter(df.date,df.deepSleepTime,c=df.deepSleepTime,cmap='brg')
        plt.title('Derin Uyku(dk)')
        grafik2 = plt.subplot(122) 
        plt.scatter(df.date,df.shallowSleepTime,c=df.shallowSleepTime,cmap="gist_rainbow")
        plt.title('Hafif Uyku(dk)')
        plt.figure(2)
        plt.scatter(df.date,df.wakeTime,c=df.wakeTime,cmap='Reds')
        plt.title('Uyku süresi')
        plt.show()
        
elif secenek == "8":
    with open('Veriler/SPORT/SPORT_1637061532364.csv','r') as csv_file:
        csv_reader = csv.reader(csv_file, delimiter=',')
        line_count = 0
        for row in csv_reader:
            if line_count == 0:
                print(f'Sütun isimleri: {", ".join(row)}')
                line_count += 1
                print()
            else:
                print(f'\t{row[0]} {row[1]} {row[2]} {row[3]} {row[4]} {row[5]} {row[6]}  {row[7]}')
                line_count += 1
                print()
        print(f'{line_count} satır işlendi')
        
elif secenek == "9":
    with open('Veriler/USER/USER_1637061531994.csv','r') as csv_file:
        csv_reader = csv.reader(csv_file, delimiter=',')
        line_count = 0
        for row in csv_reader:
            if line_count == 0:
                print(f'Sütun isimleri: {", ".join(row)}')
                line_count += 1
                print()
            else:
                print(f'\t{row[0]} {row[1]} {row[2]} {row[3]} {row[4]} {row[5]} {row[6]} ')
                line_count += 1
                print()
        print(f'{line_count} satır işlendi')
elif secenek=="10":
    starihi = input("Bakmak istediğiniz tarihi giriniz : (Örn : 2021-11-11) \n")
    
    with open('Veriler/ACTIVITY/ACTIVITY_1637061532025.csv','r') as csv_file:
        csv_reader = csv.reader(csv_file, delimiter=',')
        line_count = 0
        adimkontrol =0
        sadimsayisi = 7000
        for row in csv_reader:
            if row[0] == starihi:
                adimkontrol = row[1]
                if  int(adimkontrol) > sadimsayisi:
                    print("Bu kadar yürüyüşün üstüne su içmeyi unutmayın !")
                else:
                    print("Daha çok yürümelisiniz !")
            else:
                line_count += 1
    csv_file.close()
    
    with open('Veriler/HEARTRATE/HEARTRATE_1637061532248.csv','r') as csv_file:
        csv_reader = csv.reader(csv_file, delimiter=',')
        line_count = 0
        kalpkontrol=0
        for row in csv_reader:
            if row[0] == starihi:
                kalpkontrol = row[1]
                if (int(kalpkontrol) > 60) and (int(kalpkontrol) < 80):
                    print("Kalbiniz şıkır şıkır atıyor !")
                else:
                    print("Doktara gözükmelisiniz !")
            else:
                line_count += 1
    csv_file.close()
    
    with open('Veriler/SLEEP/SLEEP_1637061532231.csv','r') as csv_file:
        csv_reader = csv.reader(csv_file, delimiter=',')
        line_count = 0
        kontrol=0
        uykukontrol=0
        for row in csv_reader:
            if row[0] == starihi:
                uykukontrol = row[1]
                if  int(uykukontrol) > 60:
                    print("Mışıl mışıl uyumuşsunuz !")
                else:
                    print("Derin bir uyku çekmelisiniz !")
            else:
                line_count += 1
    csv_file.close()
else :
    print("Lütfen tekrar deneyiniz !")