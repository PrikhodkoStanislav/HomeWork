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
    connect(timer, &QTimer::timeout, this, &MainWindow::reactionSecond);
    timer->start(500);
    scene->addItem(time);
    numericDisplay();
    connect(ui->gmtBox, SIGNAL(valueChanged(int)), SLOT(reactionGMTMSK()));
    connect(ui->mskBox, SIGNAL(valueChanged(int)), SLOT(reactionMSKGMT()));
    //connect(ui->gmtBox, &QSpinBox::valueChanged, this, &MainWindow::reactionGMTMSK);
    //connect(ui->mskBox, &QSpinBox::valueChanged, this, &MainWindow::reactionMSKGMT);
}

void MainWindow::numericDisplay()
{
    realTime = new QTime();
    QTime timeKnow = realTime->currentTime();
    QTime *timeWithGMT = new QTime(timeKnow.hour() + ui->gmtBox->value() - 4, timeKnow.minute(), timeKnow.second());
    ui->time->setText((QString)timeWithGMT->toString());
    delete timeWithGMT;
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

void MainWindow::reactionSecond()
{
    scene->removeItem(time);
    delete time;
    time = new Time(ui->gmtBox->value());
    scene->addItem(time);
    numericDisplay();
}

void MainWindow::reactionGMTMSK()
{
    ui->mskBox->setValue(ui->gmtBox->value() - 4);
}

void MainWindow::reactionMSKGMT()
{
    ui->gmtBox->setValue(ui->mskBox->value() + 4);
}
