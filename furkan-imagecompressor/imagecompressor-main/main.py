from src import cropper
from src import converter
from pathlib import Path
import os

if __name__ == "__main__":
    chooseDirectory = input("Varsayılan dizinde işlem yapılsın mı (y - n):")
    if chooseDirectory == 'y':
        inputFile = r"C:\Users\furka\OneDrive\Desktop\Haber"
        moveTo = r"C:\Users\furka\OneDrive\Desktop\Haber\export"
    else:
        inputFile = input("Görsel dizinini belirtin: ")
        moveTo = input("Lütfen çıktı dizinini belirtin: ")
    directoryFiles = os.listdir(inputFile)
    for files in directoryFiles:

        fileExt = os.path.splitext(files)[-1]
        if fileExt == '.jpg':
            cropper.imgcropper(Path(inputFile + "\\" + files), moveTo)
        elif fileExt == '.png' or fileExt == '.webp':
            converter.pngtojpg(Path(inputFile + "\\" + files), moveTo)
