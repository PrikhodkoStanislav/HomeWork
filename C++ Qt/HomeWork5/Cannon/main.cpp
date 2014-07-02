#include "cannonwindow.h"
#include <QApplication>

int main(int argc, char *argv[])
{
    QApplication a(argc, argv);
    CannonWindow w;
    w.show();

    return a.exec();
}
