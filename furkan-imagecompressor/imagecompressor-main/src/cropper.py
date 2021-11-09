import os
import shutil
from pathlib import Path
from PIL import Image


def imgenerator(newimg, cropbox, outpath, filepath):
    finalDestination = Path(outpath)
    im_crop = newimg.copy().crop(cropbox)
    newFileName = (os.path.splitext(os.path.basename(filepath))[0] + '_crop.jpg')
    im_crop.convert('RGB').resize((700, 450)).save(newFileName, optimize=True, quality=60)
    shutil.move(os.path.abspath(newFileName), finalDestination)
    print(newFileName)


def imgcropper(filepath, outpath):
    im = Image.open(filepath)
    imgWidth, imgHeight = im.size
    aspectRatio = imgWidth / imgHeight
    if 1 <= aspectRatio <= 1.56:
        cropBox = (0, round((imgHeight-(imgWidth/1.56))/2), imgWidth, round(((imgHeight-(imgWidth/1.56))/2)+(imgWidth/1.56)))
        imgenerator(im, cropBox, outpath, filepath)

    elif 1.56 < aspectRatio:
        cropBox = (round((imgWidth - (imgHeight * 1.56)) / 2), 0,  round(((imgWidth-(imgHeight * 1.56)) / 2)+(imgHeight * 1.56)), imgHeight)
        imgenerator(im, cropBox, outpath, filepath)
    elif 0.5 < aspectRatio < 1:
        print("Something is wrong")
    else:
        print("This image is portrait")
