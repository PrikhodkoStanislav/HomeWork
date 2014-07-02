#ifndef CANNONWINDOW_H
#define CANNONWINDOW_H

#include <QMainWindow>
#include <QtWidgets>

namespace Ui {
class CannonWindow;
}

class CannonWindow : public QMainWindow
{
    Q_OBJECT

public:

    explicit CannonWindow(QWidget *parent = 0);
    ~CannonWindow();

private:
    Ui::CannonWindow *ui;
    QGraphicsScene *scene;
    QGraphicsView *view;
};

#endif // CANNONWINDOW_H
