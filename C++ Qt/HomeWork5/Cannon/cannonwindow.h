#pragma once

#include <QtWidgets/QMainWindow>
#include <QtWidgets/QGraphicsScene>
#include <QtWidgets/QGraphicsView>

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
