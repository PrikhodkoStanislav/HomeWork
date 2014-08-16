#pragma once

#include <QtWidgets/QMainWindow>
#include <QtWidgets/QGraphicsScene>
#include <QtWidgets/QGraphicsView>

namespace Ui {
class MainWindow;
}

/// Class add clock on the window.
class MainWindow : public QMainWindow
{
    Q_OBJECT

public:

    explicit MainWindow(QWidget *parent = 0);
    ~MainWindow();

private:
    Ui::MainWindow *ui;
    QGraphicsScene *scene;
    QGraphicsView *view;
    QGraphicsItem *time;
    QGraphicsItem *circle;
    QTimer *timer;
    QTime *realTime;
    void numericDisplay();

private slots:
    void reactionSecond();
    void reactionGMTMSK();
    void reactionMSKGMT();
};
