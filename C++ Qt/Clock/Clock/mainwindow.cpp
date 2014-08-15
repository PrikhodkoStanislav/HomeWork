#include "mainwindow.h"
#include "ui_mainwindow.h"
#include "circle.h"
#include "time.h"
#include <QTimer>
#include <QTime>

MainWindow::MainWindow(QWidget *parent) :
    QMainWindow(parent),
    ui(new Ui::MainWindow)
{
    ui->setupUi(this);

    scene = new QGraphicsScene();
    view = new QGraphicsView(scene);
    this->ui->verticalLayout->addWidget(view);
    circle = new Circle();
    time = new Time();
    scene->addItem(circle);
    timer = new QTimer();
    connect(timer, &QTimer::timeout, this, &MainWindow::reaction);
    timer->start(500);
    scene->addItem(time);
    numericDisplay();
}

void MainWindow::numericDisplay()
{
    realTime = new QTime();
    QTime timeKnow = realTime->currentTime();
    ui->time->setText((QString)timeKnow.toString());
}

MainWindow::~MainWindow()
{
    delete realTime;
    delete timer;
    delete time;
    delete circle;
    delete scene;
    delete view;
    delete ui;
}

void MainWindow::reaction()
{
    scene->removeItem(time);
    delete time;
    time = new Time();
    scene->addItem(time);
    numericDisplay();
}
