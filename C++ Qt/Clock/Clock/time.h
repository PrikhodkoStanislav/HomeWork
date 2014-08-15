#pragma once

#include <QtWidgets/QWidget>
#include <QtWidgets/QGraphicsItem>
#include <QtGui/QPainter>

/// Class draw hands of the clock depending on time.
class Time : public QGraphicsItem
{
public:
    Time();
    QRectF boundingRect() const override;

    /// Return real time.
    QTime knowTime();

    /// Hand of the second.
    QLineF lineSecond();

    /// Hand of the minute.
    QLineF lineMinute();

    /// Hand of the hour.
    QLineF lineHour();

    void paint(QPainter *painter, const QStyleOptionGraphicsItem *option, QWidget *widget) override;
};
